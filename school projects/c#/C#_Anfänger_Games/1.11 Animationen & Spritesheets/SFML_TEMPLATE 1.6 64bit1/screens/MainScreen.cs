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
        Animation anim;
        int speed;
        int a;
        int b;
        bool punch;
        Texture spritesheet = new Texture("assets/spritesheet.png");
        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            
            anim = new Animation(this, spritesheet, 8, 4);

            
            anim.setSpeed(speed);
            b = 1;
            a = 1;
            anim.Scale = new Vector2f(a, b);
            anim.Position = new Vector2f(100, 100);
            anim.Origin = new Vector2f((spritesheet.Size.X/8)/2,(spritesheet.Size.Y/4)/2);
            speed = 10;
            game.gameWindow.KeyPressed += GameWindow_KeyPressed;

        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {

            if (punch == false)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Add))
                {
                    speed += 1;
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.Subtract))
                {
                    speed -= 1;
                }
                anim.setSpeed(speed);

                if (Keyboard.IsKeyPressed(Keyboard.Key.A))
                {
                    anim.Scale = new Vector2f(-a, b);
                    int[] run = new int[] { 24, 25, 26, 27, 28, 29, 30, 31 };

                    anim.setAnimation(run);
                    anim.repeating = true;
                    anim.Position.X -= 1;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                {
                    anim.Scale = new Vector2f(a, b);
                    int[] run = new int[] { 24, 25, 26, 27, 28, 29, 30, 31 };

                    anim.setAnimation(run);
                    anim.repeating = true;
                    anim.Position.X += 1;
                }

                else { anim.repeating = false;
                    int[] stand = new int[] { 0 };
                    anim.setAnimation(stand);
                }
            }
        

            

            anim.loop();
        }

        private void GameWindow_KeyPressed(object sender, KeyEventArgs e)
        {
            if(e.Code == Keyboard.Key.P)
            {
                int[] schlag = new int[] { 5, 4, 3, 4, 5 };
                anim.setAnimation(schlag);
                speed = 5;
                punch = true;
            }
            else
            {
                punch = false;
                int[] stand = new int[] { 0 };
                anim.setAnimation(stand);
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            anim.render();
        }
    }
}
