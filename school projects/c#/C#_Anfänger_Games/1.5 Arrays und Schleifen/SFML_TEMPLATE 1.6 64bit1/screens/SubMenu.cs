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

namespace SFML_TEMPLATE_1._6_64bit1.screens
{
    class SubMenu : SubScreen
    {

        Button resume;
        Button close;

        public SubMenu(Screen parentScreen) : base(parentScreen)
        {

        }

        public override void setup()
        {
            resume = new Button(this, new Vector2f(300, 200), new Vector2f(200, 50), "Resume", 20);
            close = new Button(this, new Vector2f(300, 300), new Vector2f(200, 50), "Close", 20);
        }

        public override void loop()
        {
            if (resume.click)
            {
                //Return to parentScreen, close Menu
                goBack();
            }

            if (close.click)
            {
                //Ends program
                game.gameWindow.Close();

            }

            //Loop objects of this submenu
            resume.loop();
            close.loop();


            //Uncomment to update the parentScreen, else parentScreen will be "frozen"
            //parentScreen.loop();
        }

        public override void render()
        {
            //Render the parentScreen
            parentScreen.render();

            //Render own Objects ontop of parentScreen
            resume.draw();
            close.draw();
        }


    }
}
