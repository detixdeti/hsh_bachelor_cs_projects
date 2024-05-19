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

namespace _1._19_Tilemaps_.framework
{
    abstract class Screen
    {

        public Game game;

        public void setGame(Game _game)
        {

            game = _game;
        }

        public abstract void setup();

        public abstract void loop();

        public abstract void render();

        public void draw(Drawable obj)
        {
            game.gameWindow.Draw(obj);

        }

    }
}
