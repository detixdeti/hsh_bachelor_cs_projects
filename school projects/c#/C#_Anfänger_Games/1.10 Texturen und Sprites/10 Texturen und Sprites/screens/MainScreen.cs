using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _10_Texturen_und_Sprites.entities;
using _10_Texturen_und_Sprites.framework;
using _10_Texturen_und_Sprites.utility;
using _10_Texturen_und_Sprites.screens;

namespace _10_Texturen_und_Sprites.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        Texture duckTexture = new Texture("assets/duck.png");
        Sprite duck;
        float a;
        float b;
        Color duckc;
        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            a = 10f;
            b = 10f;
            duckc = new Color(255,255,255);

            duck = new Sprite(duckTexture);
            duck.Position = new Vector2f(400, 300);
            duck.Scale = new Vector2f(a, b);
            duck.Origin = duck.Scale / 2;
            duck.Color = duckc;
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                b += 2f;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
            {
                b -= 2f;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
            {
                a += 2f;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
            {
                a -= 2f;
            }
            duck.Scale = new Vector2f(a, b);

            if (Keyboard.IsKeyPressed(Keyboard.Key.Add))
            {
                duckc.R += 1;
                duckc.G += 1;
                duckc.B += 1;
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Subtract))
            {
                duckc.R -= 1;
                duckc.G -= 1;
                duckc.B -= 1;
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(duck);
        }
    }
}
