using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _1._19_Tilemaps_.entities;
using _1._19_Tilemaps_.framework;
using _1._19_Tilemaps_.utility;
using _1._19_Tilemaps_.screens;

namespace _1._19_Tilemaps_.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        Tilemap map;
        RectangleShape player;
        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {

            Texture tileset = new Texture("assets/tileset32x32.png");
            map = new Tilemap(this,tileset,"assets/tileset.tmx");

            player = new RectangleShape();
            player.Size = new Vector2f(20, 20);
            player.FillColor = Color.Black;

            
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            map.loop();
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                player.Position -= new Vector2f(0, 2);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                player.Position += new Vector2f(0, 2);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                player.Position -= new Vector2f(2, 0);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                player.Position += new Vector2f(2, 0);
            }

            FloatRect playerhitbox = player.GetGlobalBounds();

            List<Vector2i> list = map.collideWhere(playerhitbox, new int[] { 2, 3 }, 0);
            for (int i = 0; i < list.Count; i++)
            {
                map.setTile(list[i].X, list[i].Y, 1);
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            map.render();
            draw(player);
        }
    }
}
