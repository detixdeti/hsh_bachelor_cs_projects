using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using PingPong.entities;
using PingPong.framework;
using PingPong.utility;
using PingPong.screens;

namespace PingPong.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        CircleShape ball;
        RectangleShape Spieler1;
        RectangleShape Spieler2;
        Vector2f speed = new Vector2f();
        Random zufall = new Random();
        Button knopf;


        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            //Kopf
            knopf = new Button(this, new Vector2f(350, 550), new Vector2f(100, 40), "Start", 20);




            ball = new CircleShape();
            ball.Position = new Vector2f(400, 300);
            ball.Radius = 10;
            ball.Origin = new Vector2f(10, 10);

            Spieler1 = new RectangleShape();
            Spieler1.Size = new Vector2f(20, 150);
            Spieler1.Position = new Vector2f(0, 300);
            Spieler1.FillColor = Color.Blue;
            Spieler1.Origin = new Vector2f(0, 75);
            

            Spieler2 = new RectangleShape();
            Spieler2.Size = new Vector2f(20, 150);
            Spieler2.Position = new Vector2f(780, 300);
            Spieler2.FillColor = Color.Red;
            Spieler2.Origin = new Vector2f(0, 75);

            

            

        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {

            //Kopf
            knopf.loop();

            //Spielt fängt an wenn man die Leertaste drückt
            ball.Position += speed;
            if (knopf.click)
            {

                speed = new Vector2f(-20, 0);
            }
                                   
        
            //Wenn der Ball die Spieler berührt prallt er ab                 

            if (ball.GetGlobalBounds().Intersects(Spieler1.GetGlobalBounds()))
            {
                speed.X = speed.X * -1;
                speed.Y = speed.Y + zufall.Next(-3, 3);
            }

            if (ball.GetGlobalBounds().Intersects(Spieler2.GetGlobalBounds()))
            {
                speed.X = speed.X * -1;
                speed.Y = speed.Y + zufall.Next(-3, 3);
            }



            //Ball rand abprallen

            if (ball.Position.X <= 0 || ball.Position.X >= 800)
            {
                ball.Position = new Vector2f(400, 300);
                speed = new Vector2f(0, 0);
            }


            if (ball.Position.Y <= 0 || ball.Position.Y >= 600)
            {
                speed.Y = speed.Y * -1;

            }


            //Kugel ändert die Farbe

            Color C = ball.FillColor;
            C.R = 255;
            C.B += 1;
            C.G += 1;

            ball.FillColor = C;

            //Oberen Rand nicht berühren
            if (Spieler1.Position.Y <= 75)
            {
                Spieler1.Position = new Vector2f(0, 75);
            }

            if (Spieler2.Position.Y <= 75)
            {
                Spieler2.Position = new Vector2f(780, 75);
                  }

                //Unteren Rand nicht berühren

                if (Spieler1.Position.Y >= 525)
                {
                    Spieler1.Position = new Vector2f(0, 525);
                }

                if (Spieler2.Position.Y >= 525)
                {
                    Spieler2.Position = new Vector2f(780, 525);

                }

            

            //  W-S Up-Down

            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                Spieler1.Position += new Vector2f(0, -15);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                Spieler1.Position += new Vector2f(0, 15);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                Spieler2.Position += new Vector2f(0, -15);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
            {
                Spieler2.Position += new Vector2f(0, 15);
            }

        }
           

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
           
            draw(ball);
            draw(Spieler1);
            draw(Spieler2);

            knopf.draw();
        }
    }
}
