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

        //Konstanten
        float ballRadius = 10;
        int ballAnzahl = 100;

        // Deklariere hier Objekte oder Klassenvariablen!
        CircleShape[] circles = new CircleShape[100];
        Vector2f[] vectors = new Vector2f[100];
        Random rand = new Random();

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {

            for (int i = 0; i < circles.Length; i++)
            {
                circles[i] = new CircleShape();

                circles[i].Radius = ballRadius;

                circles[i].Origin = new Vector2f(ballRadius, ballRadius);

                circles[i].Position = new Vector2f(rand.Next(100, 700), rand.Next(100,500));

                if( i % 3 == 0)
                {
                    circles[i].FillColor = Color.Red;
                }
                else if (i % 3 == 1)
                {
                    circles[i].FillColor = Color.Green;
                }
                if (i % 3 == 2)
                {
                    circles[i].FillColor = Color.Yellow;
                }

                vectors[i] = new Vector2f(rand.Next(-5, 5), rand.Next(-5, 5));
            }


        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            for (int i = 0; i < circles.Length; i++)
            {
                circles[i].Position += vectors[i];


                if(circles[i].Position.X < 0 + ballRadius)
                {
                    vectors[i].X = -vectors[i].X;
                }

                if (circles[i].Position.Y < 0 + ballRadius)
                {
                    vectors[i].Y = -vectors[i].Y;
                }

                if (circles[i].Position.X > 800 - ballRadius)
                {
                    vectors[i].X = -vectors[i].X;
                }

                if (circles[i].Position.Y > 600 - ballRadius)
                {
                    vectors[i].Y = -vectors[i].Y;
                }



            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            for (int i = 0; i < circles.Length; i++)
            {
                draw(circles[i]);
            }
        }
    }
}
