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
    abstract class SubScreen : Screen
    {
        protected Screen parentScreen;

        public SubScreen(Screen parentScreen)
        {
            this.parentScreen = parentScreen;
        }

        public void goBack()
        {
            game.activeScreen = parentScreen;
        }
    }
}
