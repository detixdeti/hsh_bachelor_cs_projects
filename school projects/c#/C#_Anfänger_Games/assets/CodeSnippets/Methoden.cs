using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Methoden.entities;
using Methoden.framework;
using Methoden.utility;
using Methoden.screens;

namespace Methoden.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        List<RectangleShape> shapes;
        Random rand;
        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            shapes = new List<RectangleShape>();
            rand = new Random();

            generateRects(30);

        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            if(Keyboard.IsKeyPressed(Keyboard.Key.R))
            {
                generateRects(30);
            }

            rotateRects();
           
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                draw(shapes[i]);
            }
        }

        public void rotateRects()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                for (int n = 0; n < shapes.Count; n++)
                {
                    FloatRect A = shapes[i].GetGlobalBounds();
                    FloatRect B = shapes[n].GetGlobalBounds();
                    if(sameColor(shapes[i],shapes[n]) && A.Intersects(B) && i != n) 
                    {
                        shapes[i].Position = VectorMath.rotateVectorByAngle(shapes[i].Position - shapes[n].Position, 5) + shapes[n].Position;
                       
                    }
                }
            }
        }

        public int countCollisions(RectangleShape Rect)
        {
            int collisions = 0;
            FloatRect hitbox = Rect.GetGlobalBounds();
            for (int i = 0; i < shapes.Count; i++)
            {
                FloatRect shapeBox = shapes[i].GetGlobalBounds();
                if (hitbox.Intersects(shapeBox))
                {
                    collisions++;
                }
            }

            return collisions;
        }

        public bool sameColor(RectangleShape A, RectangleShape B)
        {
            if(A.FillColor == B.FillColor)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void generateRects(int amount)
        {
            shapes.Clear();
            for (int i = 0; i < amount; i++)
            {
                RectangleShape shape = new RectangleShape();
                shape.Size = new Vector2f(rand.Next(30, 100), rand.Next(30, 100));
                shape.Position = new Vector2f(rand.Next(50, 750), rand.Next(50, 550));
                shape.Origin = shape.Size * 0.5f;
                shape.FillColor = new Color((byte)(155 + rand.Next(0, 2) * 100), (byte)(155 + rand.Next(0, 2) * 100), (byte)(155 + rand.Next(0, 2) * 100));
                shapes.Add(shape);
            }
        }
    }
}
