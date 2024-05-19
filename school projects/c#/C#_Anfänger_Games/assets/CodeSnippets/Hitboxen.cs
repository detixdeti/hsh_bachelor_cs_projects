using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Hitboxen.entities;
using Hitboxen.framework;
using Hitboxen.utility;
using Hitboxen.screens;

namespace Hitboxen.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape player;
        CircleShape ball;
        RectangleShape wand;
        Vector2f ballVector;


        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            player = new RectangleShape();
            player.Position = new Vector2f(200,200);
            player.FillColor = Color.Green;
            player.Size = new Vector2f(50,50);

            ball = new CircleShape();
            ball.Position = new Vector2f(600, 100);
            ball.FillColor = Color.Yellow;
            ball.Radius = 25;
            ball.Origin = new Vector2f(1, 1) * ball.Radius;

            wand = new RectangleShape();
            wand.Position = new Vector2f(375,300);
            wand.Size = new Vector2f(200, 300);
            wand.FillColor = new Color(120,120,120);

            ballVector = new Vector2f(7,-5);
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            Vector2f moveVector = new Vector2f();

            if(Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                moveVector += new Vector2f(0,-30);
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                moveVector += new Vector2f(-30, 0);
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                moveVector += new Vector2f(0, 30);
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                moveVector += new Vector2f(30, 0);
            }

            player.Position += moveVector;

            FloatRect wandHitBox = wand.GetGlobalBounds();
            FloatRect playerHitBox = player.GetGlobalBounds();

            /*
            if(wandHitBox.Intersects(playerHitBox))
            {
                player.Position -= moveVector;
            }
            */

            
            while(wandHitBox.Intersects(playerHitBox))
            {
                moveVector *= 0.5f;
                player.Position -= moveVector;
                playerHitBox = player.GetGlobalBounds();


                if(moveVector.X < 0.5f && moveVector.Y < 0.5f && 
                    moveVector.X > -0.5f && moveVector.Y > -0.5f)
                {
                    player.Position -= moveVector;
                    break;
                }
            }
            



            ball.Position += ballVector;

            if(ball.Position.X > 800 - ball.Radius || ball.Position.X < 0 + ball.Radius) {
                ballVector.X = -ballVector.X;
            }

            if (ball.Position.Y > 600 - ball.Radius || ball.Position.Y < 0 + ball.Radius) {
                ballVector.Y = -ballVector.Y;
            }




            FloatRect ballHitBox = ball.GetGlobalBounds();

            if(ballHitBox.Intersects(wandHitBox))
            {
                ball.Position -= ballVector;

                if(ball.Position.X < wand.Position.X ||ball.Position.X > wand.Position.X + wand.Size.X)
                {
                    ballVector.X = -ballVector.X;
                }

                if (ball.Position.Y < wand.Position.Y || ball.Position.Y > wand.Position.Y + wand.Size.Y)
                {
                    ballVector.Y = -ballVector.Y;
                }
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(player);
            draw(ball);
            draw(wand);
        }
    }
}
