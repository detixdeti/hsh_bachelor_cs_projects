using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using ShaderGame.entities;
using ShaderGame.framework;
using ShaderGame.utility;
using ShaderGame.screens;
using System.IO;

namespace ShaderGame.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!


        Text text;
        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            NetworkServer.startServer(7667);

            if(NetworkServer.serverRunning == false)
            {
                throw new Exception("Server couldnt Start! Port was probably already taken!");
            }

            text = new Text("Messages:", new Font("assets/arial.ttf"), 20);
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            List<List<String>> msgList = NetworkServer.read();

            for (int i = 0; i < msgList.Count; i++)
            {
                for (int j = 0; j < msgList[i].Count; j++)
                {
                    text.DisplayedString += msgList[i][j];
                }
            }

        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(text);
        }




        
    }
}
