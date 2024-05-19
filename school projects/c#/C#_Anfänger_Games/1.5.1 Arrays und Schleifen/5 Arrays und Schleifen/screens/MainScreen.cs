using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _5_Arrays_und_Schleifen.entities;
using _5_Arrays_und_Schleifen.framework;
using _5_Arrays_und_Schleifen.utility;
using _5_Arrays_und_Schleifen.screens;

namespace _5_Arrays_und_Schleifen.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape[] shapes = new RectangleShape[10];

        RectangleShape[] shapes1 = new RectangleShape[100];
        

        RectangleShape[] shapes2 = new RectangleShape[100];

        CircleShape[] kreis = new CircleShape[10];

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {

            //Eigenschaften geben von einem Rectangel shape Aufgabe 1

            
            for (int i = 0; i < 10; i++)
            {
                shapes[i] = new RectangleShape();
                shapes[i].Size = new Vector2f(50, 50);
                shapes[i].Position = new Vector2f(100*i + 0, 550);
                shapes[i].Origin = shapes[i].Size / 2;
                shapes[i].FillColor = Color.Yellow;
            }


            //Schachbrett Lösung von Jannick
            //Weiß
            
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    shapes1[x+y*10] = new RectangleShape();
                    shapes1[x + y * 10].Size = new Vector2f(50, 50);
                    shapes1[x + y * 10].Position = new Vector2f(100 * x + 0, y * 100);

                }
            }

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    shapes2[x + y * 10] = new RectangleShape();
                    shapes2[x + y * 10].Size = new Vector2f(50, 50);
                    shapes2[x + y * 10].Position = new Vector2f(100 * x + 50, y * 100 + 50);

                }
            }
            


            //Aufgabe 3

            


        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            //Rotation der Rectangelshapes unten Aufgabe 1
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Rotation += 35;
            }

        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            //Alle Ractangle Shapes zeichenen aufeinmal Aufgabe 1
            for (int i = 0; i < shapes.Length; i++)
            {
                draw(shapes[i]);
            }

            for (int i = 0; i < shapes1.Length; i++)
            {
                draw(shapes1[i]);
            }

            for (int i = 0; i < shapes2.Length; i++)
            {
                draw(shapes2[i]);
            } 

            for (int i = 0; i < kreis.Length; i++)
            {
                draw(kreis[i]);
            }
        }
    }
}
