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
