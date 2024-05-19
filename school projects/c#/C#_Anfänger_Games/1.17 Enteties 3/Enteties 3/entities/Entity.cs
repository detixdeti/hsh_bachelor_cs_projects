﻿using System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;
using System.Text;
using Enteties_3.framework;
using Enteties_3.screens;

namespace Enteties_3.entities
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
