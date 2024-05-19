using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _5_Arrays_und_Schleifen.entities;
using _5_Arrays_und_Schleifen.framework;
using _5_Arrays_und_Schleifen.utility;

namespace _5_Arrays_und_Schleifen.framework
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
