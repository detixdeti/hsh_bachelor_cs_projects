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
using _1._19_Tilemaps_.screens;

namespace _1._19_Tilemaps_.framework
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
