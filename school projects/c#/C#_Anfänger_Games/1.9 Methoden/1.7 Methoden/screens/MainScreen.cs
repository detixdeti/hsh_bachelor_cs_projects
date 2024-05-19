using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _1._7_Methoden.entities;
using _1._7_Methoden.framework;
using _1._7_Methoden.utility;
using _1._7_Methoden.screens;

namespace _1._7_Methoden.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape [] shapes = new RectangleShape[50];
        Random zufall = new Random();
        Font font;
        Text text;
        int count = new int();
        

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i] = new RectangleShape();
                shapes[i].Size = new Vector2f(20, 20);
                shapes[i].Position = new Vector2f(zufall.Next(20, 780), zufall.Next(20, 580));
                shapes[i].Origin = shapes[i].Size /2;
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                if (i % 2 == 0)
                {
                    shapes[i].FillColor = Color.Blue;
                }

                if (i % 2 == 1)
                {
                    shapes[i].FillColor = Color.Red;
                }
            }

            //aaaaa
            font = new Font("assets/arial.ttf");
            text = new Text("Es berühren" + count.ToString() + "es", font, 50);
            text.Position = new Vector2f(100, 100);
            count = 0;
        }

        public bool eins(RectangleShape vier, RectangleShape funf)
        {
            if(vier.FillColor == funf.FillColor)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }
            
        public void test(RectangleShape a, RectangleShape b)
        {
            if (a.GetGlobalBounds().Intersects(b.GetGlobalBounds()) & a.FillColor == b.FillColor)
            {
                a.Rotation += 10f;
                b.Rotation += 10f;
            }
        }

        public int counter(RectangleShape a)
        {
            
            for (int i = 0; i < shapes.Length; i++)
            {
                if (a.GetGlobalBounds().Intersects(shapes[i].GetGlobalBounds()))
                {
                    count += 1;
                }
            }
            
            return count;

        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            if (eins(shapes[0], shapes[2]))
            {
                shapes[1].Rotation += 34f;
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                for (int t = 0; t < shapes.Length; t++)
                {
                    if(i != t)
                    {
                        test(shapes[i], shapes[t]);
                    }
                }
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                counter(shapes[1]);
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
