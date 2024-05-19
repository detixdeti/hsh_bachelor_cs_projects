using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Objekterstellung.entities;
using Objekterstellung.framework;
using Objekterstellung.utility;
using Objekterstellung.screens;

namespace Objekterstellung.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape box;
        RectangleShape boxA;
        RectangleShape d1;
        CircleShape d2;
        RectangleShape d3;
        CircleShape d4;
        RectangleShape e1;
        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!


        public override void setup()
        {
            box = new RectangleShape();
            box.Size = new Vector2f(800, 600);
            box.Position = new Vector2f(0, 0);
            box.FillColor = Color.White;

            boxA = new RectangleShape();
            boxA.Size = new Vector2f(40, 30);
            boxA.Position = new Vector2f(0, 300);
            boxA.FillColor = Color.Black;
            boxA.Rotation += 34f;

            d1 = new RectangleShape();
            d1.Size = new Vector2f(40, 100);
            d1.Position = new Vector2f(40, 100);
            d1.FillColor = Color.Red;

            d2 = new CircleShape();
            d2.Position = new Vector2f(35, 100);
            d2.Radius = 50;
            d2.FillColor = Color.Red;

            d3 = new RectangleShape();
            d3.Size = new Vector2f(40, 100);
            d3.Position = new Vector2f(0, 100);
            d3.FillColor = Color.White;

            d4 = new CircleShape();
            d4.Position = new Vector2f(50, 120);
            d4.Radius = 30;
            d4.FillColor = Color.White;

            e1 = new RectangleShape();
            e1.Position = new Vector2f(150, 100);
            e1.Size = new Vector2f(70, 100);
            e1.FillColor = Color.Red;


        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            boxA.Rotation += 100f;
            boxA.Position += new Vector2f(1, 0);
            
            
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(box);
            draw(boxA);
            
            draw(d2);
            draw(d3);
            draw(d4);
            draw(d1);

            draw(e1);
            
            
        }
    }
}
