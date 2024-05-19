using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Klassen.entities;
using Klassen.framework;
using Klassen.utility;
using Klassen.screens;
using Klassen.Extra;

namespace Klassen.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!


        Font arial; 
        Text name;
        Text energie;
        Text shield;
        Text speed;
        
        RectangleShape energiebox;
        RectangleShape shieldbox;
        RectangleShape speedbox;

        spaceship current;

        spaceship number1;
        spaceship number2;
        spaceship number3;

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            arial = new Font("assets/arial.ttf");
            name = new Text("name", arial, 30);
            name.Position = new Vector2f(350, 50);

            energie = new Text("energie", arial, 30);
            energie.Position = new Vector2f(100, 200);
            energiebox = new RectangleShape();
            energiebox.Size = new Vector2f(100, 30);
            energiebox.Position = new Vector2f(250, energie.Position.Y);

            shield = new Text("shield", arial, 30);
            shield.Position = new Vector2f(100, 250);
            shieldbox = new RectangleShape();
            shieldbox.Size = new Vector2f(100, 30);
            shieldbox.Position = new Vector2f(250, shield.Position.Y);

            speed = new Text("speed",arial, 30);
            speed.Position = new Vector2f(100, 300);
            speedbox = new RectangleShape();
            speedbox.Size = new Vector2f(100, 30);
            speedbox.Position = new Vector2f(250, speed.Position.Y);

            number1 = new spaceship("number1", 110, 90, 39);
            number2 = new spaceship("number2", 150, 80, 20);
            number3 = new spaceship("number3", 120, 100, 10);

current = number1;
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            
            name.DisplayedString = current.name;
            energiebox.Size = new Vector2f(current.energie * 1.5f, energiebox.Size.Y);
            shieldbox.Size = new Vector2f(current.shield * 1.5f, shieldbox.Size.Y);
            speedbox.Size = new Vector2f(current.speed * 1.5f, speedbox.Size.Y);

            if (Keyboard.IsKeyPressed(Keyboard.Key.Num1))
            {
                current = number1;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Num2))
            {
                current = number2;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Num3))
            {
                current = number3;
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(name);
            draw(energie);
            draw(shield);
            draw(speed);
            draw(energiebox);
            draw(shieldbox);
            draw(speedbox);

        }
    }
}
