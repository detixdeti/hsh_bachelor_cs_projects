using Animationen.framework;
using SFML.Graphics;
using SFML.System;

namespace Animationen.entities
{
    /// <summary>
    /// This class represents an Animation in an SFML context
    /// </summary>
    class Animation
    {
        /// <summary>
        /// The Graphic holding all animation frames
        /// </summary>

        private Texture spritesheet;

        /// <summary>
        /// Array of with each individual frame
        /// </summary>

        private Sprite[] frames;

        /// <summary>
        /// Frame that is currently displayed
        /// </summary>

        private Sprite currentFrame;

        /// <summary>
        ///  The currently active Animation
        /// </summary>
        private int[] currentAnim;

        /// <summary>
        /// The state of the current Animation
        /// </summary>
        public int animationIndex;

        /// <summary>
        /// Reference to the current game screen
        /// </summary>
        private Screen screen;

        /// <summary>
        /// The speed of the animation
        /// </summary>
        public float framesPerSecond
        {
            get;
            private set;
        }

        /// <summary>
        /// Variable counts the time of a frame
        /// </summary>
        private float timer;

        /// <summary>
        /// while true, animation will not continue
        /// </summary>
        public bool paused;

        /// <summary>
        /// While true, animation will repeat
        /// </summary>
        public bool repeating;

        /// <summary>
        /// The position in pixel coordinates, starting upper left corner
        /// </summary>
        public Vector2f Position;

        /// <summary>
        /// The rotation of the animation, in degrees(0-360), counter-clockwise
        /// </summary>
        public float Rotation;

        /// <summary>
        /// The origin of the animation relative to upper left corner of frame
        /// </summary>
        public Vector2f Origin;

        /// <summary>
        /// The Scale of the animation, where 1f is normal Size, 2f is double etc.
        /// </summary>
        public Vector2f Scale;

        /// <summary>
        /// The tinting of the frames
        /// </summary>
        public Color Color;

        /// <summary>
        /// Creates a new Animation object from the given spritesheet
        /// </summary>
        /// <param name="screen">Reference to the current screen</param>
        /// <param name="spritesheet">Texture containing a spritesheet</param>
        /// <param name="columns">Amount of columns in the spritesheet</param>
        /// <param name="rows">Amount of rows in the spritesheet</param>
        public Animation(Screen screen, Texture spritesheet, int columns, int rows)
        {
            this.screen = screen;
            this.spritesheet = spritesheet;

            //Calculate size of a single frame
            int frameWidth = (int)spritesheet.Size.X / columns;
            int frameHeight = (int)spritesheet.Size.Y / rows;

            //Initialize Array to hold all frames
            frames = new Sprite[columns*rows];

            //Save individual frames in sprite array
            for (int y = 0; y < rows; y++) 
            {
                for (int x = 0; x < columns; x++)
                {
                    frames[y * columns + x] = new Sprite(spritesheet, 
                        new IntRect(x*frameWidth, y*frameHeight, frameWidth, frameHeight));
                }
            }

            this.currentAnim = new int[] {0};
            this.currentFrame = frames[currentAnim[animationIndex]];
            this.animationIndex = 0;
            this.timer = 0;
            this.framesPerSecond = 10;
            this.paused = false;
            this.Position = new Vector2f(0,0);
            this.Color = Color.White;
            this.Rotation = 0;
            this.Scale = new Vector2f(1, 1);
            this.Origin = new Vector2f(0,0);
        }

        /// <summary>
        /// Call this every loop() to update the animation
        /// </summary>
        public void loop()
        {
            //Increase timer by a 1/60th of a second when not paused
            if(!paused)
            {
                timer += 1;
            }

            //when time limit is reached, change to next frame
            if (timer > 60f / framesPerSecond)
            {
                timer -= 60f / framesPerSecond;

                //Increase animation index until length of currentAnim is reached
                if(animationIndex < currentAnim.Length - 1)
                {
                    animationIndex++;
                }
                //When looping is active, start from beginning
                else if (repeating)
                {
                    animationIndex = 0;
                }
            }

            currentFrame = frames[currentAnim[animationIndex]];
        }

        /// <summary>
        /// Draw the Animation
        /// </summary>
        public void render()
        {
            currentFrame.Position = this.Position;
            currentFrame.Rotation = this.Rotation;
            currentFrame.Color = this.Color;
            currentFrame.Scale = this.Scale;
            currentFrame.Origin = this.Origin;

            screen.draw(currentFrame);
        }

        /// <summary>
        /// Resets and pauses current Animation
        /// </summary>
        public void stop()
        {
            this.paused = true;
            animationIndex = 0;
        }

        /// <summary>
        /// Resets the current Animation to its start
        /// </summary>
        public void reset()
        {
            animationIndex = 0;
        }

        /// <summary>
        /// Set a new animation
        /// </summary>
        /// <param name="animation">The new animaton</param>
        public void setAnimation(int[] animation)
        {
            currentAnim = animation;
            animationIndex = animationIndex % currentAnim.Length;
        }

        /// <summary>
        /// Get the hitbox of the animation
        /// </summary>
        /// <returns>A floatrect acting as a hitbox</returns>
        public FloatRect GetGlobalBounds()
        {
            currentFrame.Position = this.Position;
            currentFrame.Rotation = this.Rotation;
            currentFrame.Scale = this.Scale;
            currentFrame.Origin = this.Origin;

            return currentFrame.GetGlobalBounds();
        }

        /// <summary>
        /// Sets the active frame of the current animation
        /// </summary>
        /// <param name="frame">An index within the current animation</param>
        public void setIndex(int frame)
        {
            animationIndex = frame % currentAnim.Length;
        }

        /// <summary>
        /// Sets the frames per Second, negative values or 0 will be ignored. Use "paused" to pause an animation
        /// </summary>
        /// <param name="framesPerSecond">The amount of frames that should be displayed each seconds</param>
        public void setSpeed(float framesPerSecond)
        {
            if(framesPerSecond > 0)
            {
                this.framesPerSecond = framesPerSecond;
            }
        }
    }
}
