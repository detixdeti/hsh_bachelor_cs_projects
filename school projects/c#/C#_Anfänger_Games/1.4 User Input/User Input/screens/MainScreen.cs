using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using User_Input.entities;
using User_Input.framework;
using User_Input.utility;
using User_Input.screens;

namespace User_Input.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape box;
        Sprite bild;
        Texture tex;
        float alpha = 0;
        float s = 5;

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            box = new RectangleShape();
            box.Size = new Vector2f(80, 50);
            box.Position = new Vector2f(100, 100);
            box.FillColor = Color.White;
            box.Origin = new Vector2f(25, 25);

            game.gameWindow.KeyPressed += onKeyPressed;
            game.gameWindow.KeyReleased += onKeyRelease;

            tex = new Texture("assets/bild.png");
            bild = new Sprite(tex);
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        
        {
            //Farbewechsel 

            Color c = box.FillColor;
            c.R += 1;
            c.B += 1;
            c.G += 2;


            box.FillColor = c;

            //WASD Tasten bewegen
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                box.Position += new Vector2f(0, -1);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                box.Position += new Vector2f(0, 1);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                box.Position += new Vector2f(-1, 0);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                box.Position += new Vector2f(1, 0);
            }
            //Drücke der Linken sich nach link drehen und andersrum auch

            if (Mouse.IsButtonPressed(Mouse.Button.Left))
            {
                box.Rotation += -2f;
            }
            if (Mouse.IsButtonPressed(Mouse.Button.Right))
            {
                box.Rotation += 2f;
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
            {
                box.Rotation += -2f;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
            {
                box.Rotation += 2f;
            }

            //V Größe verdoppel  und B soll es halbieren

           

            //Ein Objekt soll mit der Pfeiloben Taste nach "Vorne" fahren und mit der 
            //Pfeilunten Taste nach "hinten". Mit der Pfeilliinks und -rechts soll es sich drehen

            alpha = box.Rotation;
            
            //Grad in Bogemass
            alpha = (float)(alpha * Math.PI / 180);
            float x = s * (float)Math.Cos(alpha);
            float y = s * (float)Math.Sin(alpha);

            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                box.Position += new Vector2f(x, y);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
            {
                box.Position -= new Vector2f(x, y);
            }

           
        }

        private void onKeyRelease(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.V)
            {
                box.Size *= 2;
                box.Origin = box.Size / 2;
            }
            if (e.Code == Keyboard.Key.B)
            {
                box.Size /= 2;
                box.Origin = box.Size / 2;
            }
        }


        private void onKeyPressed(object sender, KeyEventArgs e)
        {
            
            
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(box);
            draw(bild);
        }
    }
}
