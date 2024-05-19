using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML_TEMPLATE_1._6_64bit1.entities;
using SFML_TEMPLATE_1._6_64bit1.framework;
using SFML_TEMPLATE_1._6_64bit1.utility;
using SFML_TEMPLATE_1._6_64bit1.screens;

namespace SFML_TEMPLATE_1._6_64bit1.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!

        CircleShape[] shapes = new CircleShape[100];
        Random Zufall = new Random();
        Vector2f [] Speed = new Vector2f[100];

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            for (int i = 0; i < 100; i++)
            {
                shapes[i] = new CircleShape();
                shapes[i].Radius = 10;
                shapes[i].Origin = new Vector2f(5,5);
                shapes[i].Position = new Vector2f(Zufall.Next(5 ,795),Zufall.Next(5,595));
                
               
            }

            for (int i = 0; i < 100; i++)
            {
                Speed[i] = new Vector2f(Zufall.Next(-5,5),Zufall.Next(-5,5));
                
            }

            for (int i = 0; i < 100; i++)
            {
                if( i % 3 == 0)
                {
                    shapes[i].FillColor = Color.Blue;
                }

                if (i % 3 == 1)
                {
                    shapes[i].FillColor = Color.Red;
                }

                if (i % 3 == 2)
                {
                    shapes[i].FillColor = Color.White;
                }


            }

        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            for (int i = 0; i < 100; i++)
            {
                shapes[i].Position += Speed[i];

            }

            for (int i = 0; i < 100; i++)
            {
                if (shapes[i].Position.X <= 5 || shapes[i].Position.X >= 795)
                {
                    Speed[i].X = Speed[i].X * -1;
                }

            }

            for (int i = 0; i < 100; i++)
            {
                if (shapes[i].Position.Y <= 5 || shapes[i].Position.Y >= 595)
                {
                    Speed[i].Y = Speed[i].Y * -1;
                }

            }



        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                draw(shapes[i]);
            }

        }
    }
}
