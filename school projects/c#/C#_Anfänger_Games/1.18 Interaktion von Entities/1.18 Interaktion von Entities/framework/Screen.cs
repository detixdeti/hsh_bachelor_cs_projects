using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _1._18_Interaktion_von_Entities.entities;
using _1._18_Interaktion_von_Entities.framework;
using _1._18_Interaktion_von_Entities.utility;

namespace _1._18_Interaktion_von_Entities.framework
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
