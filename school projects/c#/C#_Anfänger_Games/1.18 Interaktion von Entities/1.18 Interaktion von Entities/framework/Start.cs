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
using _1._18_Interaktion_von_Entities.screens;

namespace _1._18_Interaktion_von_Entities.framework
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
