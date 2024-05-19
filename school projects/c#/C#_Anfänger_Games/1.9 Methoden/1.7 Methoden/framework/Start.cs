using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _1._7_Methoden.entities;
using _1._7_Methoden.framework;
using _1._7_Methoden.utility;
using _1._7_Methoden.screens;

namespace _1._7_Methoden.framework
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
