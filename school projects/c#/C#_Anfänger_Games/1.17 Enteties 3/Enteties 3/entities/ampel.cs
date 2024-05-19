using System;
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
    class Ampel
    {
        // Graphic Variable sollte in jeder Entity drin sein
        // RectangleShape,CircleShape oder Sprite
        public RectangleShape graphic;
        RectangleShape ampel;
        CircleShape rot;
        CircleShape gelb;
        CircleShape green;
        Screen screen;

        const int STATE_RED = 0;
        const int STATE_YELLOW = 1;
        const int STATE_GREEN = 2;
        int state = STATE_GREEN;

        int counter;

        // Konstruktor
        public Ampel(Screen parentScreen)
        {
            screen = parentScreen;
            
            ampel = new RectangleShape();
            ampel.Position = new Vector2f(100, 100);
            ampel.Size = new Vector2f(100, 300);
            ampel.FillColor = new Color(100, 100, 100);

            rot = new CircleShape();
            rot.Radius = 40f;
            rot.FillColor = Color.Red;
            rot.Position = new Vector2f(110, 120);

            gelb = new CircleShape();
            gelb.Radius = 40f;
            gelb.FillColor = Color.Yellow;
            gelb.FillColor = Color.Yellow;
            gelb.Position = new Vector2f(110, 210);

            green = new CircleShape();
            green.Radius = 40f;
            green.FillColor = Color.Green;
            green.Position = new Vector2f(110, 300);

        }

        // Loop Methode
        public void loop()
        {
            if( state == STATE_GREEN)
            {
                stateGreen();
            }
            else if ( state == STATE_YELLOW)
            {
                stateYellow();
            }
            else if (state == STATE_RED)
            {
                stateRed();
            }

            counter -= 1;
        }

        public void draw()
        {
            screen.draw(ampel);
            screen.draw(rot);
            screen.draw(gelb);
            screen.draw(green);
        }
        void stateGreen()
        {
            green.FillColor = Color.Green;
            gelb.FillColor = Color.Black;
            rot.FillColor = Color.Black;

            
        }
        void stateYellow()
        {
            green.FillColor = Color.Black;
            gelb.FillColor = Color.Yellow;
            rot.FillColor = Color.Black;
            if (counter <= 0)
            {
                state = STATE_RED;
                counter = 180;
            }
        }
        void stateRed()
        {
            green.FillColor = Color.Black;
            gelb.FillColor = Color.Black;
            rot.FillColor = Color.Red;
            if (counter <= 0)
            {
                state = STATE_GREEN;
                
            }
        }
        public void button()
        {
            if(state == STATE_GREEN)
            {
            state = STATE_YELLOW;
            counter = 180;
            }
            
        }
    }
}
