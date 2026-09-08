using ATC2027.Controls;
using ATC2027.Controls;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;


namespace ATC2027.State
{
    public abstract class AState : IComponent, IHasDevModeDrawableString
    {
        public abstract string getName { get; }

        protected Tuple<Color, Color, Color> ColorScheme;
        bool leftCtrlIsDown = false;
        bool leftShiftIsDown = false;
        bool prevLeftCtrlIsDown = false;
        bool prevLeftShiftIsDown = false;

        Text devModeText = null;

        public AState()
        {
            this.ColorScheme = new Tuple<Color,Color,Color>(Constants.primaryColor, Constants.secondaryColor, Constants.tertiaryColor);
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (Constants.DevMode)
            {
                if (devModeText != null)
                    devModeText.Draw(gameTime, spriteBatch);                
            }
        }

        public virtual void Update(GameTime gameTime)
        {
            /*
            #region enabling the press toggle of dev mode
            prevLeftCtrlIsDown = leftCtrlIsDown;
            prevLeftShiftIsDown = leftShiftIsDown;

            leftCtrlIsDown = Keyboard.GetState().IsKeyDown(Keys.LeftControl);
            leftShiftIsDown = Keyboard.GetState().IsKeyDown(Keys.LeftShift);

            if (leftCtrlIsDown && leftShiftIsDown && !prevLeftCtrlIsDown && !prevLeftShiftIsDown)
                Constants.DevMode = !Constants.DevMode;
            #endregion
            */
            
            if (Constants.DevMode)
            {
                if (Constants.contentManager != null)
                     devModeText = new Text("templateText", Constants.getArial_7(), new Vector2(35, 35), Color.Red);

                if (devModeText!=null)
                    devModeText.setText(getDevModeDrawableString());
            }
            

        }

        public abstract string getDevModeDrawableString();
    }
}
