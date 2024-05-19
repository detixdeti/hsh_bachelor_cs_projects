using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace _1._6_Projekt_Avoider.utility
{
    class NetworkServer
    {
        public static Object thisLock = new Object();

        public static List<Client> clientList;

        public static bool serverRunning = false;

        private static int port;

        private static void addClientToList(Client c)
        {
            lock (thisLock)
            {
                clientList.Add(c);
            }
        }


        private static void listenForNewClients()
        {

            TcpListener serverSocket = new TcpListener(port);

            TcpClient newClient = default(TcpClient);

            serverSocket.Start();

            bool running = true;

            int ID = 0;

            while (running)
            {
                newClient = serverSocket.AcceptTcpClient();

                Client client = new Client(newClient, ID, clientList);

                addClientToList(client);

                ID++;

                client.writeToClient("");
            }

        }

        public static void startServer(int serverPort)
        {
            if (!serverRunning)
            {
                serverRunning = true;
                port = serverPort;
                clientList = new List<Client>();
                Thread listenThread = new Thread(new ThreadStart(listenForNewClients));
                listenThread.Start();
            }
        }

        public static List<List<String>> read()
        {
            List<List<String>> allMessages = new List<List<string>>();

            for (int i = 0; i < clientList.Count; i++)
            {
                List<String> messages = clientList[i].getRequests();

                allMessages.Add(messages);
            }

            return allMessages;
        }

        public static void writeToAll(String message)
        {
            for (int i = 0; i < clientList.Count; i++)
            {
                clientList[i].writeToClient(message);
            }
        }

        public static void writeToClient(int ID, String message)
        {
            for (int i = 0; i < clientList.Count; i++)
            {
                if (clientList[i].ID == ID)
                {
                    clientList[i].writeToClient(message);
                }
            }
        }

        public static int getIDbyIndex(int index)
        {
            return clientList[index].ID;
        }



        public class Client
        {
            TcpClient socket;
            public int ID;
            String buffer;
            Thread listenThread;
            List<Client> list;
            List<String> requests;

            public Client(TcpClient socket, int ID, List<Client> list)
            {
                this.socket = socket;
                this.ID = ID;
                this.buffer = "";
                this.requests = new List<String>();
                this.list = list;

                listenThread = new Thread(listenToClient);
                listenThread.Start();

            }

            private void writeToRequests(List<String> newRequests)
            {
                lock (thisLock)
                {
                    requests.AddRange(newRequests);
                }
            }

            public List<String> getRequests()
            {

                List<String> msgs = new List<string>();

                lock (thisLock)
                {
                    msgs.AddRange(requests);
                    requests.Clear();
                }

                return msgs;
            }

            public void writeToClient(String message)
            {
                if (socket.Connected)
                {
                    lock (thisLock)
                    {
                        NetworkStream outStream = socket.GetStream();

                        Byte[] broadcastBytes = null;

                        //Replace start/endsign of message with encoding
                        message = message.Replace("<", "<open>");
                        message = message.Replace(">", "<close>");
                        message = message.Replace("~", "<start>");
                        message = message.Replace("$", "<end>");

                        broadcastBytes = Encoding.ASCII.GetBytes("<ID>" + this.ID + "</ID>" + "~" + message + "$");

                        outStream.Write(broadcastBytes, 0, broadcastBytes.Length);

                        outStream.Flush();
                    }
                }
            }

            private void listenToClient()
            {
                if (socket.Connected)
                {
                    byte[] bytesFrom = new byte[10025];

                    List<String> msgs = new List<string>();

                    NetworkStream client = socket.GetStream();

                    bool running = true;
                    while (running)
                    {
                        msgs.Clear();

                        try
                        {
                            client.Read(bytesFrom, 0, socket.ReceiveBufferSize);

                            buffer += System.Text.Encoding.ASCII.GetString(bytesFrom);

                            //Check if complete message is in buffer
                            while (buffer.IndexOf("~") >= 0 && buffer.IndexOf("$") >= 0 && buffer.Length > 0)
                            {
                                int start = buffer.IndexOf("~") + 1;
                                int end = buffer.IndexOf("$");

                                if (start <= end)
                                {
                                    String message = buffer.Substring(start, end - start);

                                    //Revert character replacement in message
                                    message = message.Replace("<close>", ">");
                                    message = message.Replace("<open>", "<");
                                    message = message.Replace("<start>", "~");
                                    message = message.Replace("<end>", "$");

                                    msgs.Add(message);
                                }
                                else
                                {
                                    //Remove garbage from buffer
                                    buffer = buffer.Substring(start);
                                }

                                //Remove message from buffer
                                buffer = buffer.Substring(end + 1);
                            }

                            writeToRequests(msgs);

                        }
                        catch (Exception e)
                        {
                            socket.Close();
                            running = false;
                            lock (thisLock)
                            {
                                list.Remove(this);
                            }

                        }
                    }
                }
            }
        }
    }
}
