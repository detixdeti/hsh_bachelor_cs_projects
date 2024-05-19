using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Client.entities;
using Client.framework;
using Client.utility;
using Client.screens;

namespace Client.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        Text text;


        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            NetworkClient.connectTo("127.0.0.1", 1000);

            if(NetworkClient.isConnected == false)
            {
                throw new Exception("Could not connect to the server!");
            }

            text = new Text("Messages:", new Font("assets/arial.ttf"), 20);
            
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {

            if (NetworkClient.isConnected == false)
            {
                throw new Exception("Connection lost!");
            }

            List<String> msgs = NetworkClient.read();

            for (int i = 0; i < msgs.Count; i++)
            {
                text.DisplayedString += msgs[0];
            }

            NetworkClient.send("Hello");

        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(text);
        }
    }
}
