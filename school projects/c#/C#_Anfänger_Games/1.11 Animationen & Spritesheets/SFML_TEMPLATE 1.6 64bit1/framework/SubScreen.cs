using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML_TEMPLATE_1._6_64bit1.entities;
using SFML_TEMPLATE_1._6_64bit1.framework;
using SFML_TEMPLATE_1._6_64bit1.utility;
using SFML_TEMPLATE_1._6_64bit1.screens;

namespace SFML_TEMPLATE_1._6_64bit1.framework
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
