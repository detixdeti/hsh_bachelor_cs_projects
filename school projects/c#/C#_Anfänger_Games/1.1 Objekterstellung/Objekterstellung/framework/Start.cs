using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Objekterstellung.entities;
using Objekterstellung.framework;
using Objekterstellung.utility;
using Objekterstellung.screens;

namespace Objekterstellung.framework
{
    class Start
    {
        static void Main()
        {
            Game game = new Game();

            game.startGame();
        }

    }
}
