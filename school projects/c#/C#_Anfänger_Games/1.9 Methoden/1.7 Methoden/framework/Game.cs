﻿using System;
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
    class Game
    {
        public RenderWindow gameWindow;

        public Screen activeScreen;

        public const uint SCREEN_WIDTH = 800;

        public const uint SCREEN_HEIGHT = 600;

        public void startGame()
        {


            gameWindow = new RenderWindow(new VideoMode(SCREEN_WIDTH, SCREEN_HEIGHT), "SFML");

            gameWindow.Closed += new EventHandler(OnClose);

            gameWindow.SetFramerateLimit(60);

            gameWindow.SetKeyRepeatEnabled(false);

            activeScreen = new MainScreen();

            activeScreen.setGame(this);

            activeScreen.setup();

            while (gameWindow.IsOpen)
            {
                gameWindow.DispatchEvents();

                gameWindow.Clear();

                activeScreen.loop();

                activeScreen.render();

                gameWindow.Display();
            }

        }

        public void switchScreen(Screen newScreen)
        {
            activeScreen = newScreen;
            newScreen.setGame(this);
            newScreen.setup();

        }

        void OnClose(object sender, EventArgs e)
        {
            gameWindow.Close();
        }
    }
}
