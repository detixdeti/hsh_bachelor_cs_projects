using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SuperPhysics.entities;
using SuperPhysics.framework;
using SuperPhysics.utility;
using SuperPhysics.screens;
using Box2DX.Collision;
using Box2DX.Dynamics;
using Box2DX.Common;

namespace SuperPhysics.screens
{
    class MainScreen : Screen
    {
        // Deklariere hier Objekte oder Klassenvariablen!

        World world;

        Body ground;
        RectangleShape groundGraphic;

        Body box;
        RectangleShape boxGraphic;

        Body box2;
        BodyDef boxDef2;
        RectangleShape boxGraphic2;

        int forceCounter = 0;

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {
            AABB bounds = new AABB();
            bounds.LowerBound = new Vec2(-2000, -1000);
            bounds.UpperBound = new Vec2(2000,2000);

            world = new World(bounds, new Vec2(0, 10), false);


            View view = game.gameWindow.GetView();
            view.Size = new Vector2f(200,150);
            view.Center = new Vector2f(0,0);
            game.gameWindow.SetView(view);

            // Create Ground Shape & Body
            PolygonDef groundShape = new PolygonDef();
            groundShape.SetAsBox(1000.0f, 5.0f);

            BodyDef groundDef = new BodyDef();
            groundDef.Position.Set(0.0f, -5.0f);
            ground = world.CreateBody(groundDef);
            ground.CreateShape(groundShape);


            // Create Box Shape
            PolygonDef boxShape = new PolygonDef();
            float size = 2.5f;
            boxShape.SetAsBox(size, size);
            boxShape.Density = 0.1f;

            // Create Dynamic Box Body
            BodyDef boxDef = new BodyDef();
            boxDef.Position = new Vec2(0,-25);
            boxDef.LinearDamping = 0.8f;
            boxDef.AngularDamping = 0.9f;
            box = world.CreateBody(boxDef);
            box.CreateShape(boxShape);
            box.SetMassFromShapes();

            // Create Dynamic Box Body
            boxDef2 = new BodyDef();
            boxDef2.Position = new Vec2(0, -40);
            boxDef2.LinearDamping = 0.8f;
            boxDef2.AngularDamping = 0.9f;
            box2 = world.CreateBody(boxDef2);
            box2.CreateShape(boxShape);
            box2.SetMassFromShapes();



            // Create Rectangleshapes as graphical representation
            groundGraphic = new RectangleShape();
            groundGraphic.Size = new Vector2f(1000.0f * 2, 5*2);
            groundGraphic.FillColor = SFML.Graphics.Color.Blue;
            groundGraphic.Origin = groundGraphic.Size * 0.5f;

            boxGraphic = new RectangleShape();
            boxGraphic.Size = new Vector2f(size*2,size*2);
            boxGraphic.FillColor = SFML.Graphics.Color.Green;
            boxGraphic.Origin = boxGraphic.Size * 0.5f;

            boxGraphic2 = new RectangleShape();
            boxGraphic2.Size = new Vector2f(size * 2, size * 2);
            boxGraphic2.FillColor = SFML.Graphics.Color.Red;
            boxGraphic2.Origin = boxGraphic.Size * 0.5f;

        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            if(Keyboard.IsKeyPressed(Keyboard.Key.Q) && box.GetAngularVelocity() > -2)
            {
                box.ApplyTorque(-200f);
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.E) && box.GetAngularVelocity() < 2)
            {
                box.ApplyTorque(200f);
            }

            if(forceCounter >= 60)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.W))
                {
                    box.ApplyImpulse(new Vec2(0, -100), box.GetWorldPoint(new Vec2(0, 0)));
                    forceCounter = 0;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.A))
                {
                    box.ApplyImpulse(new Vec2(-100, 0), box.GetWorldPoint(new Vec2(0, 0)));
                    forceCounter = 0;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.S))
                {
                    box.ApplyImpulse(new Vec2(0, 100), box.GetWorldPoint(new Vec2(0, 0)));
                    forceCounter = 0;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                {
                    box.ApplyImpulse(new Vec2(100, 0), box.GetWorldPoint(new Vec2(0, 0)));
                    forceCounter = 0;
                }
                
            }
            else
            {
                forceCounter++;
            }
            

            world.Step(1 / 60f, 3, 3);

            Vec2 boxPos = box.GetPosition();
            Vec2 boxPos2 = box2.GetPosition();
            Vec2 groundPos = ground.GetPosition();

            boxGraphic.Position = new Vector2f(boxPos.X, boxPos.Y);
            boxGraphic2.Position = new Vector2f(boxPos2.X, boxPos2.Y);
            groundGraphic.Position = new Vector2f(groundPos.X, groundPos.Y);

            boxGraphic.Rotation = VectorMath.radToDeg(box.GetAngle());
            boxGraphic2.Rotation = VectorMath.radToDeg(box2.GetAngle());
            groundGraphic.Rotation = VectorMath.radToDeg(ground.GetAngle());
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            draw(groundGraphic);
            draw(boxGraphic);
            draw(boxGraphic2);
        }
    }
}
