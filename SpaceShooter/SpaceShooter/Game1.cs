﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShooter
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        internal enum State
        {
            MENU,
            PLAY
        }
        GraphicsDeviceManager myGfx;
        SpriteBatch mySprBatch;
        static State myGState;

        public Game1()
        {
            myGfx = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            IsMouseVisible = true;
            myGfx.PreferredBackBufferWidth = 1280; //Window Width
            myGfx.PreferredBackBufferHeight = 720; //Window Height
            myGfx.ApplyChanges();

            myGState = State.PLAY;
            mySprBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            switch (myGState)
            {
                case State.MENU:
                    //Blank for now
                    break;
                case State.PLAY:
                    //Blank for now
                    break;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.TransparentBlack);

            mySprBatch.Begin();
            switch (myGState)
            {
                case State.MENU:
                    //Blank for now
                    break;
                case State.PLAY:
                    //Blank for now
                    break;
            }
            mySprBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
