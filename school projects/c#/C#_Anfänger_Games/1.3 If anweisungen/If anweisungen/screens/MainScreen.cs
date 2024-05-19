using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using If_anweisungen.entities;
using If_anweisungen.framework;
using If_anweisungen.utility;
using If_anweisungen.screens;

namespace If_anweisungen.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!

            RectangleShape box;
        RectangleShape box2;
        int state;

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            box = new RectangleShape();
            box.Position = new Vector2f(50, 50);
            box.FillColor = Color.White;
            box.Size = new Vector2f(50, 50);
            box.Origin = new Vector2f(25, 25);

            box2 = new RectangleShape();
            box2.Position = new Vector2f(50, 50);
            box2.FillColor = Color.White;
            box2.Size = new Vector2f(50, 50);
            box2.Origin = new Vector2f(25, 25);
            state = 1;
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            box.Rotation += 35;
            box.Position += new Vector2f(5, 0);
            //Aufgabe wenn er den Rechten Rand berührt nach links verschieben
            if (box.Position.X >= 800)
            {
                box.Position = new Vector2f(0, box.Position.Y);
            }
            //Aufgabe Linke seite Grün und rechte Rot
            if ( (box.Position.X >= 0) && (box.Position.X <= 400))
            {
                box.FillColor = Color.Green;
            }

            else
            {
                box.FillColor = Color.Red;
            }

            //Aufgabe eine Trapezformigen Pfad bewegen
            box2.Rotation += 35;
           

          

            if ((box.Position.X >= 0) && (box.Position.X <= 400))
            {
                box2.FillColor = Color.Green;
            }

            else
            {
                box2.FillColor = Color.Red;
            }

            //Trapezformigen Pfad machen mit dem int State

           if (state == 1)
            {
                box2.Position += new Vector2f(5, 5);
                if ((box2.Position.X >= 800) || (box2.Position.Y >= 600)|| (box2.Position.X <= 0) || (box2.Position.Y <= 0))
                {
                    state = 2;
                }
            }

            if (state == 2)
            {
                box2.Position += new Vector2f(5, -5);
                if ((box2.Position.X >= 800) || (box2.Position.Y >= 600) || (box2.Position.X <= 0) || (box2.Position.Y <= 0))
                {
                    state = 3;
                }
            }

            if (state == 3)
            {
                box2.Position += new Vector2f(-5, -5);
                if ((box2.Position.X >= 800) || (box2.Position.Y >= 600)|| (box2.Position.X <= 0) || (box2.Position.Y <= 0))
                {
                    state = 4;
                }

            }

            if (state == 4)
            {
                box2.Position += new Vector2f(-5, 5);
                if ((box2.Position.X >= 800) || (box2.Position.Y >= 600) || (box2.Position.X <= 0) || (box2.Position.Y <= 0))
                {
                    state = 1;
                }
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(box);
            draw(box2);
        }
    }
}
