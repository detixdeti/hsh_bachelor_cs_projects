using System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;
using System.Text;
using If_anweisungen.framework;
using If_anweisungen.screens;

namespace If_anweisungen.entities
{
    class Particle
    {
        // Graphic Variable sollte in jeder Entity drin sein
        // RectangleShape,CircleShape oder Sprite
        public RectangleShape graphic;

        List<Particle> particles;
        Screen screen;
        Vector2f velocity;
        int lifetime;

        // Konstruktor
        public Particle(Screen parentScreen, List<Particle> particles, Vector2f startPos, Vector2f velocity, int lifetime)
        {
            screen = parentScreen;
            graphic = new RectangleShape();
            graphic.Position = startPos;
            graphic.Size = new Vector2f(4, 4);
            graphic.FillColor = Color.Red;
            this.velocity = velocity;
            this.lifetime = lifetime;
            this.particles = particles;
        }

        // Loop Methode
        public void loop()
        {
            graphic.Position += velocity;


            lifetime--;
            if (lifetime <= 0)
            {
                particles.Remove(this);
            }
        }


        public void draw()
        {
            screen.draw(this.graphic);
        }


    }
}
