using System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;
using System.Text;
using SFML_TEMPLATE_1._6_64bit1.framework;
using SFML_TEMPLATE_1._6_64bit1.screens;

namespace SFML_TEMPLATE_1._6_64bit1.entities
{
    class Emitter
    {
        // Graphic Variable sollte in jeder Entity drin sein
        // RectangleShape,CircleShape oder Sprite

        Screen screen;
        public Vector2f position;
        List<Particle> particles;
        public float minX;
        public float minY;
        public float maxX;
        public float maxY;
        public int minLife;
        public int maxLife;
        Random rnd;

        // Konstruktor
        public Emitter(Screen parentScreen, List<Particle> particles)
        {
            screen = parentScreen;
            this.particles = particles;
            position = new Vector2f(0, 0);
            rnd = new Random();

            // Standart Werte, sollten in Mainscreen überschrieben werden
            this.minX = -5;
            this.minY = -5;
            this.maxX = 5;
            this.maxY = 5;
            this.minLife = 10;
            this.maxLife = 20;
        }

        // Loop Methode
        public void loop()
        {



        }

        public void emit(int count)
        {
            for (int i = 0; i < count; i++)
            {
                float vecX = (float)rnd.NextDouble() * (maxX - minX) + minX;
                float vecY = (float)rnd.NextDouble() * (maxY - minY) + minY;
                int lifetime = rnd.Next((maxLife - minLife)) + minLife;

                particles.Add(new Particle(screen, particles, this.position, new Vector2f(vecX, vecY), lifetime));
            }
        }
    }
}
