using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using User_Input.entities;
using User_Input.framework;
using User_Input.utility;

namespace User_Input.framework
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
