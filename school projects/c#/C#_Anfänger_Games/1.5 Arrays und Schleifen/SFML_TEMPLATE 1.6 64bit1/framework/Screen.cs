using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML_TEMPLATE_1._6_64bit1.entities;
using SFML_TEMPLATE_1._6_64bit1.framework;
using SFML_TEMPLATE_1._6_64bit1.utility;

namespace SFML_TEMPLATE_1._6_64bit1.framework
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
