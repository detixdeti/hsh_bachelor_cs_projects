using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Objekte_Bewegen.entities;
using Objekte_Bewegen.framework;
using Objekte_Bewegen.utility;
using Objekte_Bewegen.screens;

namespace Objekte_Bewegen.framework
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
