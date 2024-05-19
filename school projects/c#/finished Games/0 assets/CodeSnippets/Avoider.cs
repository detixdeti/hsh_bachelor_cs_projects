using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Avoider.entities;
using Avoider.framework;
using Avoider.utility;
using Avoider.screens;

namespace Avoider.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape player;

        List<RectangleShape> walls;

        List<CircleShape> hitters;

        List<Vector2f> movePoints;

        RectangleShape target;

        float hitterSpeed;
        float playerSpeed;

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            hitterSpeed = 8.0f;
            playerSpeed = 3.0f;

            //Player erstellen
            player = new RectangleShape();
            player.Size = new Vector2f(9,9);
            player.FillColor = new Color(50,255, 50);
            player.Position = new Vector2f(100, 100);
            player.Origin = player.Size * 0.5f;
            player.OutlineThickness = 3;
            player.OutlineColor = new Color(0, 200, 0);

            walls = new List<RectangleShape>();

            //Wände erstellen
            RectangleShape wall;

            #region World bounds
            wall = new RectangleShape();
            wall.Size = new Vector2f(1000,100);
            wall.Position = new Vector2f(-100,-50);
            wall.FillColor = new Color(150,150,255);
            walls.Add(wall);

            wall = new RectangleShape();
            wall.Size = new Vector2f(1000, 100);
            wall.Position = new Vector2f(-100, 550);
            wall.FillColor = new Color(150, 150, 255);
            walls.Add(wall);

            wall = new RectangleShape();
            wall.Size = new Vector2f(100, 800);
            wall.Position = new Vector2f(-50, -100);
            wall.FillColor = new Color(150, 150, 255);
            walls.Add(wall);

            wall = new RectangleShape();
            wall.Size = new Vector2f(100, 800);
            wall.Position = new Vector2f(750, -100);
            wall.FillColor = new Color(150, 150, 255);
            walls.Add(wall);
            #endregion

            #region 1st Passage
            wall = new RectangleShape();
            wall.Size = new Vector2f(700, 300);
            wall.Position = new Vector2f(150, 0);
            wall.FillColor = new Color(150, 150, 255);
            walls.Add(wall);

            wall = new RectangleShape();
            wall.Size = new Vector2f(700, 150);
            wall.Position = new Vector2f(120, 150);
            wall.FillColor = new Color(150, 150, 255);
            walls.Add(wall);

            wall = new RectangleShape();
            wall.Size = new Vector2f(50, 150);
            wall.Position = new Vector2f(30, 150);
            wall.FillColor = new Color(150, 150, 255);
            walls.Add(wall);
            #endregion

            #region Target Area

            wall = new RectangleShape();
            wall.Size = new Vector2f(50, 225);
            wall.Position = new Vector2f(600, 300);
            wall.FillColor = new Color(150, 150, 255);
            walls.Add(wall);

            wall = new RectangleShape();
            wall.Size = new Vector2f(200, 200);
            wall.Position = new Vector2f(675, 450);
            wall.FillColor = new Color(150, 150, 255);
            walls.Add(wall);


            #endregion

            #region Kreisbewegungspunkte
            movePoints = new List<Vector2f>();

            movePoints.Add(new Vector2f(50, 300));
            movePoints.Add(new Vector2f(580, 300));

            movePoints.Add(new Vector2f(580, 325));
            movePoints.Add(new Vector2f(50, 325));

            movePoints.Add(new Vector2f(50, 350));
            movePoints.Add(new Vector2f(580, 350));

            movePoints.Add(new Vector2f(580, 375));
            movePoints.Add(new Vector2f(50, 375));

            movePoints.Add(new Vector2f(50, 400));
            movePoints.Add(new Vector2f(580, 400));

            movePoints.Add(new Vector2f(580, 425));
            movePoints.Add(new Vector2f(50, 425));

            movePoints.Add(new Vector2f(50, 450));
            movePoints.Add(new Vector2f(580, 450));

            movePoints.Add(new Vector2f(580, 475));
            movePoints.Add(new Vector2f(50, 475));

            movePoints.Add(new Vector2f(50, 500));
            movePoints.Add(new Vector2f(580, 500));

            movePoints.Add(new Vector2f(580, 525));
            movePoints.Add(new Vector2f(50, 525));
            #endregion

            #region Kreise erstellen
            hitters = new List<CircleShape>();

            for(int i = 0; i < movePoints.Count; i += 2)
            {
                movePoints[i] += new Vector2f(12.5f, 12.5f);
                movePoints[i+1] += new Vector2f(12.5f, 12.5f);

                CircleShape hitter = new CircleShape();
                hitter.FillColor = new Color(200, 50, 50);
                hitter.Radius = 6;
                hitter.Position = movePoints[i];
                hitter.Origin = new Vector2f(1, 1) * hitter.Radius;
                hitter.OutlineThickness = 3;
                hitter.OutlineColor = new Color(200, 0, 0);
                hitters.Add(hitter);
            }
            #endregion

            #region Ziel erstellen
            target = new RectangleShape();
            target.Size = new Vector2f(100, 150);
            target.Position = new Vector2f(650, 300);
            target.FillColor = new Color(150,255,150);

            #endregion
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            #region Spielerbewegung
            Vector2f move = new Vector2f();

            if(Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                move += new Vector2f(0,-playerSpeed);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                move += new Vector2f(-playerSpeed, 0);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                move += new Vector2f(0, playerSpeed);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                move += new Vector2f(playerSpeed, 0);
            }


            //Bewegung in X und Y Richtung aufspalten
            Vector2f moveX = new Vector2f(move.X,0);
            Vector2f moveY = new Vector2f(0, move.Y);


            // X Bewegungskontrolle
            player.Position += moveX;

            FloatRect playerHitbox = player.GetGlobalBounds();

            for (int i = 0; i < walls.Count; i++)
            {
                FloatRect wallHitbox = walls[i].GetGlobalBounds();
                while(playerHitbox.Intersects(wallHitbox))
                {
                    moveX *= 0.5f;
                    player.Position -= moveX;
                    playerHitbox = player.GetGlobalBounds();

                    if (moveX.X * moveX.X + moveX.Y * moveX.Y < 0.1f)
                    {
                        player.Position -= moveX;
                    }
                }
            }

            //Y Bewegungskontrolle
            player.Position += moveY;

            playerHitbox = player.GetGlobalBounds();

            for (int i = 0; i < walls.Count; i++)
            {
                FloatRect wallHitbox = walls[i].GetGlobalBounds();
                while (playerHitbox.Intersects(wallHitbox))
                {
                    moveY *= 0.5f;
                    player.Position -= moveY;
                    playerHitbox = player.GetGlobalBounds();

                    if (moveY.X*moveY.X+moveY.Y*moveY.Y < 0.1f)
                    {
                        player.Position -= moveY;
                    }
                }
            }

            #endregion

            #region Kreisbewegungen
            for (int i = 0; i < hitters.Count; i++)
            {
                Vector2f start = movePoints[i * 2];
                Vector2f end = movePoints[i * 2 + 1];
                CircleShape hitter = hitters[i];

                if(VectorMath.distance(end, hitter.Position) < hitterSpeed)
                {
                    hitter.Position = end;
                    movePoints[i * 2] = new Vector2f(end.X,end.Y);
                    movePoints[i * 2 + 1] = new Vector2f(start.X, start.Y);
                }
                else
                {
                    Vector2f direction = VectorMath.getUnitVector(end - hitter.Position);
                    hitter.Position += direction * hitterSpeed;
                }
            }

            #endregion

            // Spieler berührt Hitter -> Spieler wird an den Anfang gesetzt
            playerHitbox = player.GetGlobalBounds();
            for (int i = 0; i < hitters.Count; i++)
            {
                FloatRect hitterHitbox = hitters[i].GetGlobalBounds();
                if(playerHitbox.Intersects(hitterHitbox))
                {
                    player.Position = new Vector2f(100, 100);
                }
            }

            // Spieler betritt Zielzone -> Spieler gewinnt
            playerHitbox = player.GetGlobalBounds();
            FloatRect targetHitBox = target.GetGlobalBounds();

            if (targetHitBox.Contains(player.Position.X, player.Position.Y))
            {
                game.switchScreen(new ScoreScreen(0));
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            //Hintergrund rendern
            RectangleShape box = new RectangleShape();
            box.Size = new Vector2f(25, 25);
            bool colorSwap = true;

            for(int x = 0; x < 32; x++)
            {
                for (int y = 0; y < 32; y++)
                {
                    if(colorSwap)
                    {
                        box.FillColor = new Color(180, 180, 180);
                    }
                    else
                    {
                        box.FillColor = new Color(200, 200, 200);
                    }

                    box.Position = new Vector2f(x*25, y*25);
                    draw(box);
                    colorSwap = !colorSwap;
                }
                colorSwap = !colorSwap;
            }



            for(int i = 0; i < walls.Count; i++)
            {
                draw(walls[i]);
            }

            draw(target);

            for (int i = 0; i < hitters.Count; i++)
            {
                draw(hitters[i]);
            }

            draw(player);
        }
    }
}
