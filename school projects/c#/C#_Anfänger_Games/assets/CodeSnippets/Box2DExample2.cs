using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using PhysicsGame.entities;
using PhysicsGame.framework;
using PhysicsGame.utility;
using PhysicsGame.screens;
using Box2DX.Collision;
using Box2DX.Common;
using Box2DX.Dynamics;

namespace PhysicsGame.screens
{
    class MainScreen : Screen
    {
        // Box2D Physik Welt
        World world;

        // Faktor mit dem zwischen Pixel und Box2D Werten gerechnet wird
        // Entspricht Pixel/Meter
        const float ZOOM_FACTOR = 10.0f;

        // Sekunden pro Frame in Box2D
        const float TIMESTEP = 1 / 60f;

        //Wie genau Geschwindigkeiten und Positionen berechnet werden
        const int VELOCITY_ITERATIONS = 3;
        const int POSITION_ITERATIONS = 3;

        //Luftwiderstand
        const float LINEAR_DAMPING = 0.9f;

        //Drehwiderstand
        const float ANGULAR_DAMPING = 0.9f;

        // Weltgröße in Pixel
        const int WORLD_WIDTH = 800;
        const int WORLD_HEIGHT = 600;

        // Listen für die Körper aus Box2D und ihrer Shapes in SFML
        List<Body> bodies;
        List<SFML.Graphics.Shape> shapes;

        //Random Generator
        Random rand = new Random();

        //Step counter
        int steps;

        //The current power
        float power;

        //Power Display
        Text powerText;

        

        // Setup, wird immer einmal zu Beginn eines Screens aufgerufen
        // Hier Startwerte setzen!
        public override void setup()
        {

            steps = 0;
            power = 1.0f;

            bodies = new List<Body>();
            shapes = new List<SFML.Graphics.Shape>();


            AABB bounds = new AABB();

            bounds.LowerBound = new Vec2(WORLD_WIDTH / ZOOM_FACTOR, WORLD_HEIGHT / ZOOM_FACTOR)*(-0.5f);
            bounds.UpperBound = new Vec2(WORLD_WIDTH / ZOOM_FACTOR, WORLD_HEIGHT / ZOOM_FACTOR)*1.5f;

            world = new World(bounds,new Vec2(0,100), false);

            // Create Walls at World Border
            PolygonDef wallShapeDef = new PolygonDef();
            wallShapeDef.SetAsBox(0.5f * WORLD_WIDTH / ZOOM_FACTOR, 0.02f * WORLD_HEIGHT / ZOOM_FACTOR);

            BodyDef bottomWallDef = new BodyDef();
            bottomWallDef.Position = new Vec2(0.5f * WORLD_WIDTH / ZOOM_FACTOR, 0);
            Body bottomWall = world.CreateBody(bottomWallDef);
            bottomWall.CreateShape(wallShapeDef);

            BodyDef topWallDef = new BodyDef();
            topWallDef.Position = new Vec2(0.5f * WORLD_WIDTH / ZOOM_FACTOR, WORLD_HEIGHT / ZOOM_FACTOR);
            Body topWall = world.CreateBody(topWallDef);
            topWall.CreateShape(wallShapeDef);

            BodyDef leftWallDef = new BodyDef();
            leftWallDef.Position = new Vec2(0, 0.5f * WORLD_HEIGHT / ZOOM_FACTOR);
            leftWallDef.Angle = VectorMath.degToRad(90);
            Body leftWall = world.CreateBody(leftWallDef);
            leftWall.CreateShape(wallShapeDef);

            BodyDef rightWallDef = new BodyDef();
            rightWallDef.Position = new Vec2(WORLD_WIDTH / ZOOM_FACTOR, 0.5f * WORLD_HEIGHT / ZOOM_FACTOR);
            rightWallDef.Angle = VectorMath.degToRad(90);
            Body rightWall = world.CreateBody(rightWallDef);
            rightWall.CreateShape(wallShapeDef);

            bodies.Add(leftWall);
            bodies.Add(bottomWall);
            bodies.Add(rightWall);
            bodies.Add(topWall);

            shapes.Add(createShapeFromShapeDef(wallShapeDef));
            shapes.Add(createShapeFromShapeDef(wallShapeDef));
            shapes.Add(createShapeFromShapeDef(wallShapeDef));
            shapes.Add(createShapeFromShapeDef(wallShapeDef));

            game.gameWindow.KeyPressed += onKeyPress;
            game.gameWindow.MouseWheelMoved += onMouseWheel;
            game.gameWindow.MouseButtonPressed += onMousePress;

            Font font = new Font("assets/arial.ttf");
            powerText = new Text("Power: 1",font,30);
            powerText.Position = new Vector2f(600, 50);

        }

        private void onMousePress(object sender, MouseButtonEventArgs e)
        {
            if(e.Button == Mouse.Button.Left)
            {

            }

            if(e.Button == Mouse.Button.Right)
            {

            }
        }

        private void onMouseWheel(object sender, MouseWheelEventArgs e)
        {
            power += e.Delta*0.1f;
            power = System.Math.Max((float)System.Math.Round(power, 1),0);
        }

        private void onKeyPress(object sender, KeyEventArgs e)
        {
            //Create Objects when pressing buttons 
            if(e.Code == Keyboard.Key.Num0)
            {
                createRandomPolygon(new Vector2f(rand.Next(30, 770), 50), 0.1f, 30);
            }

            if (e.Code == Keyboard.Key.Num9)
            {
                createBox(new Vector2f(rand.Next(30,770),50),50,50, 0.1f);
            }

            if (e.Code == Keyboard.Key.Num8)
            {
                createCircle(new Vector2f(rand.Next(30, 770), 50),20, 0.1f);
            }
        }

        // Loop, wird jeden Frame (60 mal die Sekunde) aufgerufen
        // Hier alle Berechnungen für die Veränderung von Objekten einfügen
        public override void loop()
        {
            world.Step(TIMESTEP, VELOCITY_ITERATIONS, POSITION_ITERATIONS);
            steps++;

            powerText.DisplayedString = "Power: " + power.ToString();


            Vector2f MousePos = (Vector2f)Mouse.GetPosition(game.gameWindow);

            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                SFML.Graphics.Shape shape = shapes[i];

                Vec2 pos = body.GetPosition()*ZOOM_FACTOR;
                float angle = VectorMath.radToDeg(body.GetAngle());

                shape.Position = new Vector2f(pos.X,pos.Y);
                shape.Rotation = angle;


                // Attract Bodies to Mouse
                if (Keyboard.IsKeyPressed(Keyboard.Key.Num1))
                {
                    float distance = VectorMath.distance(MousePos, shape.Position);
                    float pullPower = power * 10000 / (distance);
                    Vector2f pullVector = VectorMath.getUnitVector(MousePos - shape.Position)
                                          * System.Math.Min(pullPower,1000);
                    Vec2 pullV = new Vec2(pullVector.X, pullVector.Y);

                    //Pull at the center of the body
                    body.ApplyForce(pullV, body.GetWorldPoint(new Vec2(0, 0)));
                }

                // Repel Bodies from Mouse
                if (Keyboard.IsKeyPressed(Keyboard.Key.Num2))
                {
                    float distance = VectorMath.distance(MousePos, shape.Position);
                    float pullPower = power * -10000 / (distance);
                    Vector2f pullVector = VectorMath.getUnitVector(MousePos - shape.Position)
                                          * System.Math.Min(pullPower, 1000);
                    Vec2 pullV = new Vec2(pullVector.X, pullVector.Y);

                    //Pull at the center of the body
                    body.ApplyForce(pullV, body.GetWorldPoint(new Vec2(0, 0)));
                }

                // Orbit Bodies to Mouse
                if (Keyboard.IsKeyPressed(Keyboard.Key.Num3))
                {
                    float distance = VectorMath.distance(MousePos, shape.Position);
                    float pullPower = power*1000 / (distance);
                    Vector2f pullVector = VectorMath.getUnitVector(MousePos - shape.Position)
                                          * System.Math.Min(pullPower, 1000);
                    pullVector = VectorMath.rotateVectorByAngle(pullVector, 90);
                    Vec2 pullV = new Vec2(pullVector.X, pullVector.Y);

                    //Pull at the center of the body
                    body.ApplyForce(pullV, body.GetWorldPoint(new Vec2(0, 0)));
                }


            }

           
        }


        public void createRandomPolygon(Vector2f position, float density, float size)
        {
            PolygonDef shapeDef = new PolygonDef();
            shapeDef.VertexCount = rand.Next(3, Settings.MaxPolygonVertices);
            shapeDef.Vertices = new Vec2[shapeDef.VertexCount];

            for(int i = 0; i < shapeDef.VertexCount; i++)
            {
                float angle = i * (float)(2 * System.Math.PI / shapeDef.VertexCount);
                float length = size*0.5f*(float)(rand.NextDouble()*0.3f + 1f) / ZOOM_FACTOR;
                shapeDef.Vertices[i] = new Vec2((float)System.Math.Cos(angle)* length, (float)System.Math.Sin(angle)*length);
            }

            shapeDef.Density = density;

            BodyDef bodyDef = new BodyDef();
            bodyDef.Position = new Vec2(position.X / ZOOM_FACTOR, position.Y / ZOOM_FACTOR);
            bodyDef.LinearDamping = LINEAR_DAMPING;
            bodyDef.AngularDamping = ANGULAR_DAMPING;
            Body body = world.CreateBody(bodyDef);
            body.CreateShape(shapeDef);
            body.SetMassFromShapes();

            bodies.Add(body);
            shapes.Add(createShapeFromShapeDef(shapeDef));
        }

        public void createCircle(Vector2f position, float radius, float density)
        {
            CircleDef shapeDef = new CircleDef();
            shapeDef.Radius = radius / ZOOM_FACTOR;
            shapeDef.Density = density;

            BodyDef bodyDef = new BodyDef();
            bodyDef.Position = new Vec2(position.X / ZOOM_FACTOR, position.Y / ZOOM_FACTOR);
            bodyDef.LinearDamping = LINEAR_DAMPING;
            bodyDef.AngularDamping = ANGULAR_DAMPING;
            Body body = world.CreateBody(bodyDef);
            body.CreateShape(shapeDef);
            body.SetMassFromShapes();

            bodies.Add(body);
            shapes.Add(createShapeFromShapeDef(shapeDef));
        }

        public void createBox(Vector2f position, float width, float height, float density)
        {
            PolygonDef shapeDef = new PolygonDef();
            shapeDef.SetAsBox(0.5f * width / ZOOM_FACTOR, 0.5f * height / ZOOM_FACTOR);
            shapeDef.Density = density;

            BodyDef bodyDef = new BodyDef();
            bodyDef.Position = new Vec2(position.X / ZOOM_FACTOR, position.Y / ZOOM_FACTOR);
            bodyDef.LinearDamping = LINEAR_DAMPING;
            bodyDef.AngularDamping = ANGULAR_DAMPING;
            Body body = world.CreateBody(bodyDef);
            body.CreateShape(shapeDef);
            body.SetMassFromShapes();

            bodies.Add(body);
            shapes.Add(createShapeFromShapeDef(shapeDef));
        }

        // Render wird immer nach loop aufgerufen
        // Hier alle draw Befehle aufrufen
        public override void render()
        {
            for(int i = 0; i < shapes.Count; i++)
            {
                draw(shapes[i]);
            }

            draw(powerText);
        }


        /// <summary>
        /// Creates a shape from a PolygonDef
        /// </summary>
        /// <param name="polygon"> The Polygondef of a body</param>
        /// <returns>A ConvexShape corresponding to the polygondef</returns>
        public SFML.Graphics.Shape createShapeFromShapeDef(PolygonDef polygon)
        {
            ConvexShape shape = new ConvexShape();
            shape.SetPointCount((uint)polygon.VertexCount);

            for(uint i = 0; i < polygon.VertexCount; i++)
            {
                Vec2 vertex = polygon.Vertices[i];
                shape.SetPoint(i, new Vector2f(vertex.X * ZOOM_FACTOR, vertex.Y * ZOOM_FACTOR));
            }

            shape.FillColor = new SFML.Graphics.Color((byte)rand.Next(100,255),(byte)rand.Next(100, 255),(byte)rand.Next(100, 255));

            return shape;
        }

        /// <summary>
        /// Creates a CirlceShape from a CircleDef
        /// </summary>
        /// <param name="circle"> The CircleDef of a body</param>
        /// <returns>A CirlceShape corresponding to the CirlceDef</returns>
        public SFML.Graphics.Shape createShapeFromShapeDef(CircleDef circle)
        {
            SFML.Graphics.CircleShape shape = new SFML.Graphics.CircleShape();

            shape.Radius = circle.Radius * ZOOM_FACTOR;
            shape.Origin = new Vector2f(shape.Radius,shape.Radius);
            shape.FillColor = new SFML.Graphics.Color((byte)rand.Next(100, 255), (byte)rand.Next(100, 255), (byte)rand.Next(100, 255));

            return shape;
        }

    }
}
