using System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;
using System.Text;
using _1._19_Tilemaps_.framework;
using _1._19_Tilemaps_.screens;

namespace _1._19_Tilemaps_.entities
{
    class Entity
    {
        // Graphic Variable sollte in jeder Entity drin sein
        // RectangleShape,CircleShape oder Sprite
        public RectangleShape graphic;

        Screen screen;

        // Konstruktor
        public Entity(Screen parentScreen)
        {
            screen = parentScreen;
            graphic = new RectangleShape();
            graphic.Size = new Vector2f(50, 50);
            graphic.FillColor = Color.Blue;
            graphic.Position = new Vector2f(300, 300);
        }

        // Loop Methode
        public void loop()
        {


        }

        public void draw()
        {
            screen.draw(this.graphic);
        }


    }
}
