using System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;
using System.Text;
using RobotArm.framework;
using RobotArm.screens;
using RobotArm.utility;

namespace RobotArm.entities
{
    class Arm
    {
        // Graphic Variable sollte in jeder Entity drin sein
        // RectangleShape,CircleShape oder Sprite
        
        Screen screen;

        public RectangleShape baseRect;
        public CircleShape baseCirc;
        

        List<RectangleShape> segments;
        List<CircleShape> joints;
        List<float> jointRotations;

        public Vector2f position;
        public float rotation;

        // Konstruktor
        public Arm(Screen parentScreen, Vector2f position, int amount)
        {
            screen = parentScreen;

            rotation = 0;
            this.position = position;

            baseRect = new RectangleShape();
            baseRect.Position = position;
            baseRect.Size = new Vector2f(100,25);
            baseRect.Origin = baseRect.Size * 0.5f;
            baseRect.FillColor = Color.Green;

            baseCirc = new CircleShape();
            baseCirc.Position = position;
            baseCirc.Radius = 25;
            baseCirc.Origin = new Vector2f(baseCirc.Radius, baseCirc.Radius*1.5f);
            baseCirc.FillColor = Color.Green;

            segments = new List<RectangleShape>();
            joints = new List<CircleShape>();
            jointRotations = new List<float>();
            Vector2f lastJoint = baseCirc.Position - baseCirc.Origin + new Vector2f(baseCirc.Radius, baseCirc.Radius / 2);

            for (int i = 0; i < amount; i++) {
                RectangleShape segment = new RectangleShape();
                segment.Position = lastJoint;
                segment.Size = new Vector2f(100, 10);
                segment.Origin = new Vector2f(0, 5);
                segment.FillColor = Color.Green;
                segments.Add(segment);

                CircleShape joint = new CircleShape();
                joint.Position = lastJoint + VectorMath.rotateVectorByAngle(new Vector2f(100, 0), 0);
                joint.Radius = 5;
                joint.FillColor = Color.Red;
                joint.Origin = new Vector2f(joint.Radius, joint.Radius);

                lastJoint = joint.Position;

                joints.Add(joint);


                jointRotations.Add(0);
            }

        }

        // Loop Methode
        public void loop()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.R))
            {
                rotation += 1;

            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Q))
            {
                rotation += 1;

            }


            if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
            {
                for(int i = 0; i < segments.Count; i++)
                {
                    jointRotations[i] -= 1;
                }
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
            {
                for (int i = 0; i < segments.Count; i++)
                {
                    jointRotations[i] += 1;
                }
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
            {
                for (int i = 1; i < segments.Count; i++)
                {
                    jointRotations[i] -= 1;
                }
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
            {
                for (int i = 1; i < segments.Count; i++)
                {
                    jointRotations[i] += 1;
                }
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                for (int i = 2; i < segments.Count; i++)
                {
                    jointRotations[i] -= 1;
                }
            }

            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                for (int i = 2; i < segments.Count; i++)
                {
                    jointRotations[i] += 1;
                }
            }

            baseRect.Position = position;
            baseCirc.Position = position;

            baseRect.Rotation = rotation;
            baseCirc.Rotation = rotation;

            for (int n = 0; n < segments.Count; n++)
            {
                segments[n].Rotation = rotation;

                joints[n].Rotation = rotation;

            }

            Vector2f lastJoint = baseRect.Position + VectorMath.rotateVectorByAngle(new Vector2f(0,-25),rotation);
            for (int n = 0; n < segments.Count; n++)
            {
                segments[n].Position = lastJoint;
                segments[n].Rotation += jointRotations[n];
                joints[n].Position = lastJoint + VectorMath.rotateVectorByAngle(new Vector2f(100, 0), segments[n].Rotation);
                lastJoint = joints[n].Position;
            }


            
            
        }

        public void draw()
        {
            screen.draw(this.baseRect);
            screen.draw(this.baseCirc);

            for (int n = 0; n < segments.Count; n++)
            {
                screen.draw(this.segments[n]);
            }

            for (int n = 0; n < segments.Count; n++)
            {
                screen.draw(this.joints[n]);
            }

        }
    }
}
