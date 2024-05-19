using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Objekte_Bewegen.entities;
using Objekte_Bewegen.framework;
using Objekte_Bewegen.utility;
using Objekte_Bewegen.screens;

namespace Objekte_Bewegen.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        RectangleShape Sonne;

        float alpha = 0;
        float r = 1;
        
        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            //Eigenschaften der Sonne 
            Sonne = new RectangleShape();
            Sonne.Size = new Vector2f(100, 100);
            Sonne.Position = new Vector2f(100, 100);
            Sonne.FillColor = Color.Yellow;
            //Mittelpunkt bestimmt
            Sonne.Origin = new Vector2f(50, 50);
            Sonne.Rotation = 45;
      
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            Sonne.Rotation += 35;
            // Farbe dauerhaft ändern
            Color c = Sonne.FillColor;
            c.R += 3;
            c.B += 3;
            c.G += 255;
            

            Sonne.FillColor = c;
            // Sonne wird zurückgesetzt
            if(Sonne.Position.X > 500)
            {
                Sonne.Position = new Vector2f(0, 0);
            }
            // Sin und Cos zu einer Kreisfunktion benutzt
            float x = r * (float)Math.Cos(alpha) + 400;
            float y = r * (float)Math.Sin(alpha) + 300;
            alpha += 0.1f;
            r = 10;

            Sonne.Position = new Vector2f(x, y);
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(Sonne);
        }
    }
}
