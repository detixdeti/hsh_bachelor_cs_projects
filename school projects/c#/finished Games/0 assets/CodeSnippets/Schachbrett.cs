using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Listen.entities;
using Listen.framework;
using Listen.utility;
using Listen.screens;

namespace Listen.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape[] schachbrett;

        int reihen = 6;
        int spalten = 8;
        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            schachbrett = new RectangleShape[reihen * spalten];

            int i = 0;
            for (int x = 0; x < spalten; x++)
            {
                for (int y = 0; y < reihen; y++)
                {
                    schachbrett[i] = new RectangleShape();

                    schachbrett[i].Size = new Vector2f(800f / spalten, 600f / reihen);

                    schachbrett[i].Position = new Vector2f(x * 100, y * 100);

                    if( (x + y) % 2 == 0)
                    {
                        schachbrett[i].FillColor = Color.Black;
                    }

                    i++;
                }
                

            }

        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {

        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            for (int i = 0; i < schachbrett.Length; i++)
            {
                draw(schachbrett[i]);
            }
        }
    }
}
