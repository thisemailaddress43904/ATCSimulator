using ATC2027.State;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ATC2027
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public AState nextState = null;
        public AState currentState = null;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            
            _graphics.PreferredBackBufferHeight = Constants.getHeightOfScreen;
            _graphics.PreferredBackBufferWidth = Constants.getWidthOfScreen;

            this.currentState = new Loading();
            this.nextState = null;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Constants.contentManager = this.Content;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (currentState.GetType().Name.EndsWith("Loading"))
            {
                Constants.spriteBatch = _spriteBatch;
                Constants.DevMode = true;

                if (Constants.spriteBatch != null)
                    nextState = new ATC2027.State.Game();

            }

            if (nextState != null)
            {
                currentState = nextState;
                nextState = null;
            }

            currentState.Update(gameTime);

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Constants.background);

            _spriteBatch.Begin();

            currentState.Draw(gameTime, _spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
