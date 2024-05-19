using System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;
using System.Text;
using _1._18_Interaktion_von_Entities.framework;
using _1._18_Interaktion_von_Entities.screens;

namespace _1._18_Interaktion_von_Entities.entities
{
    class Auto
    {
        // Graphic Variable sollte in jeder Entity drin sein
        // RectangleShape,CircleShape oder Sprite
        RectangleShape Auto1;
        CircleShape Reifen1;
        CircleShape Reifen2;


        Screen screen;

        // Konstruktor
        public Auto(Screen parentScreen)
        {
            screen = parentScreen;

            Auto1 = new RectangleShape();
            Auto1.Position = new Vector2f(100, 100);
            Auto1.Size = new Vector2f(200, 100);
            Auto1.FillColor = Color.Yellow;

            Reifen1 = new CircleShape();
            Reifen1.Position = new Vector2f(120, 180);
            Reifen1.Radius = 20f;

            Reifen2 = new CircleShape();
            Reifen2.Position = new Vector2f(240, 180);
            Reifen2.Radius = 20f;



        }

        // Loop Methode
        public void loop()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                Auto1.Position += new Vector2f(0, -10);
                Reifen1.Position += new Vector2f(0, -10);
                Reifen2.Position += new Vector2f(0, -10);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                Auto1.Position += new Vector2f(0, 10);
                Reifen1.Position += new Vector2f(0, 10);
                Reifen2.Position += new Vector2f(0, 10);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                Auto1.Position += new Vector2f(-10, 0);
                Reifen1.Position += new Vector2f(-10, 0);
                Reifen2.Position += new Vector2f(-10, 0);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                Auto1.Position += new Vector2f(10, 0);
                Reifen1.Position += new Vector2f(10, 0);
                Reifen2.Position += new Vector2f(10, 0);
            }


        }

        public void draw()
        {
            screen.draw(Auto1);
            screen.draw(Reifen1);
            screen.draw(Reifen2);

        }

        public List<FloatRect> getHitboxes()
        {
            List<FloatRect> hitboxlist = new List<FloatRect>();

            hitboxlist.Add(Reifen1.GetGlobalBounds());
            hitboxlist.Add(Reifen2.GetGlobalBounds());
            hitboxlist.Add(Auto1.GetGlobalBounds());

            return hitboxlist;
        }

        public void checkCollideWith(Auto2 other)
        {
            List<FloatRect> listA = a.getHitboxes();

        }
    }
}
