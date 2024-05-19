using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace SFML_TEMPLATE_1._6_64bit1.utility
{
    class NetworkClient
    {
        public static bool isConnected = false;
        private static String buffer = "";

        private static List<String> responses;

        private static TcpClient clientSocket;
        public static Object thisLock = new Object();
        public static int ID = -1;

        public static bool connectTo(String IP, int port)
        {
            if (!isConnected)
            {
                responses = new List<string>();
                try
                {
                    clientSocket = new TcpClient(IP, port);

                    Thread listenThread = new Thread(new ThreadStart(listenToServer));
                    listenThread.Start();
                }
                catch
                {
                    return false;
                }

                isConnected = true;
                return true;
            }
            return false;
        }

        public static List<String> read()
        {
            List<String> msgs;

            lock (thisLock)
            {
                msgs = new List<string>(responses);
                responses.Clear();
            }

            return msgs;

        }

        private static void listenToServer()
        {
            List<String> result = new List<String>();

            while (clientSocket.Connected)
            {

                try
                {
                    result.Clear();

                    NetworkStream server = clientSocket.GetStream();

                    byte[] inStream = new byte[10025];

                    server.Read(inStream, 0, clientSocket.ReceiveBufferSize);

                    buffer += System.Text.Encoding.ASCII.GetString(inStream);

                    //Remove any unreadable characters
                    int messageStart = buffer.IndexOf("~");
                    int idStart = buffer.IndexOf("<ID>");
                    int begin = 0;
                    if (messageStart >= 0 && idStart >= 0)
                    {
                        begin = Math.Min(messageStart, idStart);
                    }
                    else
                    {
                        begin = Math.Max(messageStart, idStart);
                    }

                    if (begin > 0)
                    {
                        buffer.Remove(0, begin);
                    }


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

                            result.Add(message);
                        }
                        else
                        {
                            //Remove garbage from buffer
                            buffer = buffer.Substring(start);
                        }

                        //Remove message from buffer
                        buffer = buffer.Remove(start - 1, (end + 1) - (start - 1));
                    }

                    //Check Buffer for ID Tag
                    if (buffer.IndexOf("<ID>") >= 0 && buffer.IndexOf("</ID>") >= 0 && buffer.Length > 0)
                    {
                        int start = buffer.IndexOf("<ID>") + 4;
                        int end = buffer.IndexOf("</ID>");

                        //Read out the ID Number
                        ID = int.Parse(buffer.Substring(start, end - start));

                        //Remove ID Tag from buffer
                        buffer = buffer.Remove(start - 4, (end + 5) - (start - 4));
                    }


                    lock (thisLock)
                    {
                        responses.AddRange(result);
                        result.Clear();
                    }
                }
                catch (Exception e)
                {
                    isConnected = false;
                    clientSocket.Close();

                }
            }
        }


        public static bool send(String message)
        {
            if (isConnected)
            {
                try
                {
                    NetworkStream server = clientSocket.GetStream();

                    //Replace start/endsign of message with encoding
                    message = message.Replace("<", "<open>");
                    message = message.Replace(">", "<close>");
                    message = message.Replace("~", "<start>");
                    message = message.Replace("$", "<end>");


                    byte[] outStream = System.Text.Encoding.ASCII.GetBytes("~" + message + "$");

                    server.Write(outStream, 0, outStream.Length);

                    server.Flush();

                    return true;
                }
                catch
                {
                    isConnected = false;
                    clientSocket.Close();

                    return false;
                }
            }
            else
            {
                return false;
            }

        }

    }
}
