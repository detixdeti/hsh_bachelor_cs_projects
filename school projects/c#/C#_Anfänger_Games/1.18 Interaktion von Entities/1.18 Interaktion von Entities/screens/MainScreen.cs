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

namespace _1._18_Interaktion_von_Entities.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!

            Auto auto;
        Auto auto2;


        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            auto = new Auto(this);
            auto2 = new Auto(this);

        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            auto.loop();
            auto2.loop();
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            auto.draw();
            auto2.draw();
        }
    }
}
