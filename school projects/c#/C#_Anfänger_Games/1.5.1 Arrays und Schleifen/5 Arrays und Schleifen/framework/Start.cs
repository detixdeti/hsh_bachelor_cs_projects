﻿using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _5_Arrays_und_Schleifen.entities;
using _5_Arrays_und_Schleifen.framework;
using _5_Arrays_und_Schleifen.utility;
using _5_Arrays_und_Schleifen.screens;

namespace _5_Arrays_und_Schleifen.framework
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
