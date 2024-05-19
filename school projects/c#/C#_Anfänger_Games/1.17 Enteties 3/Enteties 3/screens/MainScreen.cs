using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Enteties_3.entities;
using Enteties_3.framework;
using Enteties_3.utility;
using Enteties_3.screens;

namespace Enteties_3.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!
        Ampel ampel;
        Button start;

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            ampel = new Ampel(this);
            start = new Button(this,new Vector2f(50,50),new Vector2f(130,40),"start",30);
           


        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            ampel.loop();
            start.loop();

            if (start.click)
            {
                ampel.button();
            }
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            ampel.draw();
            start.draw();
        }
    }
}
