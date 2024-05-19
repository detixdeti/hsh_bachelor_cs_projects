using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using UserInterface.entities;
using UserInterface.framework;
using UserInterface.utility;
using UserInterface.screens;

namespace UserInterface.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        Button btn_zerfall;
        Button btn_drehen;
        Button btn_teleport;
        Button btn_reset;


        Text title;
        List<Text> buchstaben;
        List<Vector2f> buchstaben_move;
        Font font;
        Random rand;

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            Vector2f position = new Vector2f(300,300);
            Vector2f size = new Vector2f(200,50);

            font = new Font("assets/arial.ttf");

            btn_zerfall = new Button(this, position, size,"Zerfall", 20);
            btn_drehen = new Button(this, new Vector2f(300, 400), new Vector2f(200, 50),"Drehen",20);
            btn_teleport = new Button(this, new Vector2f(300, 500), new Vector2f(200, 50), "Teleport", 20);
            btn_reset = new Button(this, new Vector2f(300, 200), new Vector2f(200,50), "Reset", 20);

            title = new Text("Programmier AG", font, 50);

            title.Position = new Vector2f(400, 50);
            title.Origin = new Vector2f(title.GetGlobalBounds().Width, title.GetGlobalBounds().Height) * 0.5f;

            buchstaben = new List<Text>();
            buchstaben_move = new List<Vector2f>();
            rand = new Random();
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            btn_zerfall.loop();
            btn_drehen.loop();
            btn_teleport.loop();
            btn_reset.loop();

            if (btn_zerfall.click)
            {
                zerfall(title);
            }

            if(btn_drehen.isPressed)
            {
                drehen(title);
            }

            if (btn_teleport.click)
            {
                teleport(title);
            }

            if( btn_reset.click)
            {
                title.DisplayedString = "Programmier AG";
                title.Position = new Vector2f(400, 50);
                title.Rotation = 0;

                buchstaben.Clear();
                buchstaben_move.Clear();
            }


            for (int i = 0; i < buchstaben.Count; i++)
            {
                buchstaben_move[i] = fall(buchstaben[i], buchstaben_move[i]);
            }
        }

        public Vector2f fall(Text text, Vector2f move)
        {
            text.Position += move;
            if(text.Position.Y + text.CharacterSize > 600)
            {
                text.Position -= move;
                move.Y = - move.Y * 0.4f;
            }
            
            move += new Vector2f(0, 1);

            return move;
        }

        public void teleport(Text text)
        {
            text.Position = new Vector2f(rand.Next(100,700),rand.Next(100,500));
        }

        public void drehen(Text text)
        {
            text.Rotation += 1;
        }

        public void zerfall(Text text)
        {
            
            String s = text.DisplayedString;
            if(s.Length > 0)
            {
                String buchstabe = s.Substring(s.Length - 1);

                Text letter = new Text(buchstabe, font, title.CharacterSize);

                Vector2f pos = text.FindCharacterPos((uint)(s.Length - 1)) - text.Origin;
                pos = VectorMath.rotateVectorByAngle(pos, text.Rotation);
                pos = text.Position + pos;

                letter.Position = pos;
                letter.Rotation = text.Rotation;


                buchstaben.Add(letter);


                text.DisplayedString = s.Substring(0, s.Length - 1);

                buchstaben_move.Add(new Vector2f(0,1));
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            btn_zerfall.draw();
            btn_drehen.draw();
            btn_teleport.draw();
            btn_reset.draw();
            draw(title);

            for (int i = 0; i < buchstaben.Count; i++)
            {
                draw(buchstaben[i]);
            }
        }
    }
}
