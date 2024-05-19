using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _1._6_Projekt_Avoider.entities;
using _1._6_Projekt_Avoider.framework;
using _1._6_Projekt_Avoider.utility;
using _1._6_Projekt_Avoider.screens;

namespace _1._6_Projekt_Avoider.framework
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
