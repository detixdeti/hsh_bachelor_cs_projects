using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _1._6_Projekt_Avoider.entities;
using _1._6_Projekt_Avoider.framework;
using _1._6_Projekt_Avoider.utility;
using _1._6_Projekt_Avoider.screens;

namespace _1._6_Projekt_Avoider.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape Player;
        RectangleShape background;
        RectangleShape[] wall = new RectangleShape[16];
        CircleShape Gegner1;
        CircleShape Gegner2;
        CircleShape Gegner3;
        CircleShape Gegner4;
        Vector2f speed1 = new Vector2f();
        RectangleShape goal;
        RectangleShape start;
        RectangleShape[] shapes = new RectangleShape[6];
        RectangleShape Scoreanzeige;
        Font font;
        Text text;
        Text text2;
        int count;
        int timer;
        int zeit;
        int zeitanzeige;
        int zeitanzeigeminute;
        CircleShape[] coins = new CircleShape[4];

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            //Failsnazeige
            font = new Font("assets/arial.ttf");
            text = new Text("Fails : " + count.ToString(), font, 20);
            text.Origin = new Vector2f(text.GetLocalBounds().Width / 2, text.GetLocalBounds().Height / 2);
            text.Position = new Vector2f(690, 10);
            //Zeitanzeige
            font = new Font("assets/arial.ttf");
            text2 = new Text("Timer : " + zeitanzeigeminute.ToString() +":"+ zeitanzeige.ToString(), font, 20);
            text2.Origin = new Vector2f(text.GetLocalBounds().Width / 2, text.GetLocalBounds().Height / 2);
            text2.Position = new Vector2f(550, 10);

            //backgound
            background = new RectangleShape();
            background.Size = new Vector2f(800, 400);
            background.FillColor = new Color(180, 181, 254);

            //Player erstellen
            Player = new RectangleShape();
            Player.Size = new Vector2f(10, 10);
            Player.Origin = Player.Size / 2;
            Player.Position = new Vector2f(150, 200);
            Player.FillColor = Color.Red;
            Player.OutlineThickness = 5;
            Player.OutlineColor = Color.Black;

            //Gegner
            Gegner1 = new CircleShape();
            Gegner1.Radius = 4;
            Gegner1.Position = new Vector2f(370, 144);
            Gegner1.FillColor = Color.Blue;
            Gegner1.OutlineThickness = 5;
            Gegner1.OutlineColor = Color.Black;

            Gegner2 = new CircleShape();
            Gegner2.Radius = 4;
            Gegner2.Position = new Vector2f(370, 170);
            Gegner2.FillColor = Color.Blue;
            Gegner2.OutlineThickness = 5;
            Gegner2.OutlineColor = Color.Black;

            Gegner3 = new CircleShape();
            Gegner3.Radius = 4;
            Gegner3.Position = new Vector2f(370, 200);
            Gegner3.FillColor = Color.Blue;
            Gegner3.OutlineThickness = 5;
            Gegner3.OutlineColor = Color.Black;

            Gegner4 = new CircleShape();
            Gegner4.Radius = 4;
            Gegner4.Position = new Vector2f(370, 227);
            Gegner4.FillColor = Color.Blue;
            Gegner4.OutlineThickness = 5;
            Gegner4.OutlineColor = Color.Black;

            //start
            start = new RectangleShape();
            start.Position = new Vector2f(100, 100);
            start.Size = new Vector2f(90, 180);
            start.FillColor = new Color(182, 254, 180);

            //goal 
            goal = new RectangleShape();
            goal.Position = new Vector2f(560, 100);
            goal.Size = new Vector2f(90, 180);
            goal.FillColor = new Color(182, 254, 180);


            //Score anzeige
            Scoreanzeige = new RectangleShape();
            Scoreanzeige.Position = new Vector2f(0, 0);
            Scoreanzeige.Size = new Vector2f(750, 30);
            Scoreanzeige.FillColor = Color.Black;


            // wall's
            for (int i = 0; i < 16; i++)
            {
                wall[i] = new RectangleShape();
                wall[i].FillColor = Color.Black;
            }

            wall[1].Size = new Vector2f(5, 190);
            wall[1].Position = new Vector2f(100, 95);

            wall[2].Size = new Vector2f(150, 5);
            wall[2].Position = new Vector2f(105, 280);

            wall[3].Size = new Vector2f(90, 5);
            wall[3].Position = new Vector2f(100, 95);

            wall[4].Size = new Vector2f(5, 155);
            wall[4].Position = new Vector2f(190, 95);

            wall[5].Size = new Vector2f(30, 5);
            wall[5].Position = new Vector2f(195, 245);

            wall[6].Size = new Vector2f(5, 40);
            wall[6].Position = new Vector2f(255, 245);

            wall[7].Size = new Vector2f(5, 120);
            wall[7].Position = new Vector2f(220, 130);

            wall[8].Size = new Vector2f(270, 5);
            wall[8].Position = new Vector2f(220, 130);

            wall[9].Size = new Vector2f(270, 5);
            wall[9].Position = new Vector2f(255, 245);

            wall[10].Size = new Vector2f(5, -120);
            wall[10].Position = new Vector2f(525, 250);

            wall[11].Size = new Vector2f(5, -35);
            wall[11].Position = new Vector2f(490, 135);

            wall[12].Size = new Vector2f(155, 5);
            wall[12].Position = new Vector2f(490, 100);

            wall[13].Size = new Vector2f(-5, 185);
            wall[13].Position = new Vector2f(650, 100);

            wall[14].Size = new Vector2f(-95, 5);
            wall[14].Position = new Vector2f(650, 280);

            wall[15].Size = new Vector2f(5, -150);
            wall[15].Position = new Vector2f(555, 280);

            wall[0].Size = new Vector2f(-30, 5);
            wall[0].Position = new Vector2f(555, 130);

            //laufbahnen

            for (int i = 0; i < 6; i++)
            {
                shapes[i] = new RectangleShape();
            }

            for (int i = 0; i < 6; i++)
            {

                if (i % 2 == 0)
                {
                    shapes[i].FillColor = new Color(230, 230, 255);
                }

                if (i % 2 == 1)
                {
                    shapes[i].FillColor = new Color(247, 247, 255);
                }
                //Positionen der laufbahnen 
                shapes[0].Position = new Vector2f(490, 105);
                shapes[0].Size = new Vector2f(70, 30);

                shapes[1].Position = new Vector2f(220, 135);
                shapes[1].Size = new Vector2f(310, 26);

                shapes[2].Position = new Vector2f(220, 161);
                shapes[2].Size = new Vector2f(310, 29);

                shapes[3].Position = new Vector2f(220, 190);
                shapes[3].Size = new Vector2f(310, 30);

                shapes[4].Position = new Vector2f(220, 220);
                shapes[4].Size = new Vector2f(310, 30);

                shapes[5].Position = new Vector2f(190, 250);
                shapes[5].Size = new Vector2f(70, 30);
            }

            //coins erstellen 
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new CircleShape();
                coins[i].FillColor = Color.Yellow;
                coins[i].Radius = 4;
                coins[i].OutlineThickness = 4;
                coins[i].OutlineColor = Color.Black;
            }

            coins[1].Position = new Vector2f(370, 144);
            coins[2].Position = new Vector2f(370, 170);
            coins[3].Position = new Vector2f(370, 200);
            coins[0].Position = new Vector2f(370, 227);


            count = 00;
            timer = 30;
            zeit = 00;
            zeitanzeige = 00;
            zeitanzeigeminute = 00;

            speed1 = new Vector2f(5,0);
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            Vector2f move = new Vector2f();


            //WASD move the Player
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                move += new Vector2f(0, -2);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                move += new Vector2f(0, 2);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                move += new Vector2f(2, 0);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                move += new Vector2f(-2, 0);
            }
            //x und Y achse aufteilen
            Vector2f movex = new Vector2f(move.X,0);
            Vector2f movey = new Vector2f(0,move.Y);
            Player.Position += movex;

            FloatRect playerHitbox = Player.GetGlobalBounds();
            //Player interact with a wall in x achse
            for (int i = 0; i < wall.Length; i++)
            {
                if (playerHitbox.Intersects(wall[i].GetGlobalBounds()))
                {
                    Player.Position -= movex;
                }
            }

            Player.Position += movey;

             playerHitbox = Player.GetGlobalBounds();
            //Player interact with a wall in Y achse
            for (int i = 0; i < wall.Length; i++)
            {
                if (playerHitbox.Intersects(wall[i].GetGlobalBounds()))
                {
                    Player.Position -= movey;
                }
            }


            //Hitboxen definieren
            playerHitbox = Player.GetGlobalBounds();
            FloatRect enemy1hitbox = Gegner1.GetGlobalBounds();
            FloatRect enemy2hitbox = Gegner2.GetGlobalBounds();
            FloatRect enemy3hitbox = Gegner3.GetGlobalBounds();
            FloatRect enemy4hitbox = Gegner4.GetGlobalBounds();

            // Player interact with a Enemy

            if(playerHitbox.Intersects(enemy1hitbox) || 
                playerHitbox.Intersects(enemy2hitbox) || 
                playerHitbox.Intersects(enemy3hitbox) || 
                playerHitbox.Intersects(enemy4hitbox))
            {
                Player.Position = new Vector2f(150, 200);
                count += 1;
                
                text.DisplayedString = "Fails : " + count.ToString();
            }
            

            //Enemy Vekor (Speed1 and 2)
            Gegner1.Position += speed1;
            Gegner3.Position += speed1;
            Gegner2.Position -= speed1;
            Gegner4.Position -= speed1;

            //enemy 
            timer++;
            if (timer >= 60)
            {
                timer = 00;
                speed1 = -speed1;
            }

            //zeit ausrechenen
            zeit++;
            if (zeit >= 60)
            {
                zeit = 0;
                zeitanzeige += 1;
                text2.DisplayedString = "Timer : " + zeitanzeigeminute.ToString() + ":" + zeitanzeige.ToString();
            }

            if(zeitanzeige == 59)
            {
                zeitanzeige = 00;
                zeitanzeigeminute += 1;
            }
            //Player arrives Goal

            if (playerHitbox.Intersects(goal.GetGlobalBounds()))
            {
                game.switchScreen(new ScoreScreen(count));
                count = 0;

            }

        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(background);
            draw(Scoreanzeige);
            draw(goal);
            draw(start);

            for (int i = 0; i < shapes.Length; i++)
            {
                draw(shapes[i]);
            }

            for (int i = 0; i < wall.Length; i++)
            {
                draw(wall[i]);
            }
            /*for (int i = 0; i < coins.Length; i++)
            {
                draw(coins[i]);
            }*/
            draw(Gegner1);
            draw(Gegner2);
            draw(Gegner3);
            draw(Gegner4);

            draw(text);
            draw(text2);
            draw(Player);
        }
    }
}
