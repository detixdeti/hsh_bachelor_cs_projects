using System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;
using System.Text;
using _1._7_Methoden.framework;
using _1._7_Methoden.screens;

namespace _1._7_Methoden.entities
{
    class Button
    {
        // Graphic Variable sollte in jeder Entity drin sein
        // RectangleShape,CircleShape oder Sprite
        public RectangleShape graphic;

        public RectangleShape normal;
        public RectangleShape hover;
        public RectangleShape press;

        public Text label;

        public Boolean isPressed;
        public Boolean click;

        Screen screen;

        // Konstruktor
        public Button(Screen parentScreen, Vector2f Position, Vector2f Size, String Text, uint TextSize)
        {
            screen = parentScreen;

            isPressed = false;
            click = false;

            normal = new RectangleShape();
            normal.Size = Size;
            normal.FillColor = new Color(120, 120, 120);
            normal.Position = Position;

            hover = new RectangleShape();
            hover.Size = Size;
            hover.FillColor = new Color(180, 180, 180);
            hover.Position = Position;

            press = new RectangleShape();
            press.Size = Size;
            press.FillColor = new Color(80, 80, 80);
            press.Position = Position;

            label = new Text(Text, new Font("assets/arial.ttf"), TextSize);

            label.Position = Position + new Vector2f(
                     (normal.GetLocalBounds().Width - label.GetLocalBounds().Width) / 2,
                     (normal.GetLocalBounds().Height - label.GetLocalBounds().Height) / 4);

            graphic = normal;
        }

        public void setPosition(Vector2f newPos)
        {
            this.normal.Position = newPos;
            this.hover.Position = newPos;
            this.press.Position = newPos;

            label.Position = newPos + new Vector2f(
                       (normal.GetLocalBounds().Width - label.GetLocalBounds().Width) / 2,
                       (normal.GetLocalBounds().Height - label.GetLocalBounds().Height) / 4);

        }


        // Loop Methode
        public void loop()
        {
            Vector2f mousePos = new Vector2f(Mouse.GetPosition(screen.game.gameWindow).X, Mouse.GetPosition(screen.game.gameWindow).Y);

            if (this.graphic.GetGlobalBounds().Contains(mousePos.X, mousePos.Y))
            {
                if (Mouse.IsButtonPressed(Mouse.Button.Left))
                {
                    if (graphic == this.press)
                    {
                        click = false;
                    }
                    else click = true;

                    graphic = this.press;
                    isPressed = true;
                }
                else
                {
                    graphic = this.hover;
                    isPressed = false;
                    click = false;
                }

            }
            else
            {
                graphic = this.normal;
                isPressed = false;
                click = false;
            }
        }


        public void draw()
        {
            screen.draw(this.graphic);
            screen.draw(this.label);
        }
    }
}
