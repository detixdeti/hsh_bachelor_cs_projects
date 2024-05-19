using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFMLShaderTest.entities;
using SFMLShaderTest.framework;
using SFMLShaderTest.utility;
using SFMLShaderTest.screens;

namespace SFMLShaderTest.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!

        Shader shader;
        Texture tex;
        Sprite sprite;
        float time;
        long start;

        Vector2f movement;

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            if (!Shader.IsAvailable)
            {
                throw new Exception("Shaders are not supported on this machine");
            }

            tex = new Texture("assets/trees.png");
            //tex = new Texture(800, 600);

            movement = new Vector2f(4, 2);


            start = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            time = 0.0f;

            sprite = new Sprite(tex);

            sprite.Origin = new Vector2f(tex.Size.X,tex.Size.Y) * 0.5f;
            sprite.Position = new Vector2f(400, 300);

            shader = new Shader("assets/vertex.glsl", "assets/mine.glsl");
            shader.SetParameter("resolution", new Vector2f(800,600));

            shader.SetParameter("time", time);

            Vector2i mousePos = Mouse.GetPosition(game.gameWindow);

            shader.SetParameter("mouse", new Vector2f(mousePos.X, mousePos.Y - 300));


            shader.SetParameter("tex", Shader.CurrentTexture);
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            time += ((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond - start)/1000.0f);
            start = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            shader.SetParameter("time", time);


            Vector2i mousePos = Mouse.GetPosition(game.gameWindow);
            shader.SetParameter("mouse", new Vector2f(mousePos.X, mousePos.Y - 300));


            sprite.Position += movement;

            if(sprite.Position.Y > 600 - sprite.GetLocalBounds().Height/2)
            {
                movement.Y = -movement.Y;
            }

            if (sprite.Position.X > 800 - sprite.GetLocalBounds().Width / 2)
            {
                movement.X = -movement.X;
            }

            if (sprite.Position.Y < 0 + sprite.GetLocalBounds().Height / 2)
            {
                movement.Y = -movement.Y;
            }

            if (sprite.Position.X < 0 + sprite.GetLocalBounds().Width / 2)
            {
                movement.X = -movement.X;
            }

        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            game.gameWindow.Draw(sprite, new RenderStates(shader));
        }
    }
}
