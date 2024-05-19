using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using If_anweisungen.entities;
using If_anweisungen.framework;
using If_anweisungen.utility;
using If_anweisungen.screens;

namespace If_anweisungen.framework
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
