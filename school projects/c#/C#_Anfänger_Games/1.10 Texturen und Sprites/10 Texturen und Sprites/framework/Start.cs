using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _10_Texturen_und_Sprites.entities;
using _10_Texturen_und_Sprites.framework;
using _10_Texturen_und_Sprites.utility;
using _10_Texturen_und_Sprites.screens;

namespace _10_Texturen_und_Sprites.framework
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
