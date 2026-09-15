using ATC2027.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Reflection.Metadata.Ecma335;

namespace ATC2027
{
    public static class Constants
    {   
        public static bool DevMode = true;
        #region colors
        public static Color background => Color.Black;
        public static Color planeColor => Color.White;
        public static Color primaryColor = Color.Blue;
        public static Color secondaryColor = Color.AliceBlue;
        public static Color tertiaryColor = Color.AntiqueWhite;

        #endregion
        #region drawing

        public static ContentManager contentManager;
        public static SpriteBatch? spriteBatch = null;
        public static SpriteBatch getSpriteBatch()
        {
            if (spriteBatch == null)
            {
                throw new NullReferenceException("spriteBatch was null");
            }
            return spriteBatch; 
        }

        #endregion
        #region fonts
        private static SpriteFont? arial_5 = null;
        public static SpriteFont getArial_5()
        {
            if (arial_5 == null) 
                arial_5 = contentManager.Load<SpriteFont>("gameFont");
            return arial_5;
        }
        private static SpriteFont? arial_7 = null;
        public static SpriteFont getArial_7()
        {
            if (arial_7 == null)
                arial_7 = contentManager.Load<SpriteFont>("Arial_7");
            return arial_7;
        }

        private static SpriteFont? arial_12 = null;
        public static SpriteFont getArial_12()
        {
            if (arial_12 == null)
                arial_12 = contentManager.Load<SpriteFont>("Arial_12");
            return arial_12;
        }
        #endregion
        #region keyboard
        public static KeyboardState getKeyboardState() => Keyboard.GetState();

        public static GraphicsDevice getGraphicsDevice()
        {
            return getSpriteBatch().GraphicsDevice;
        }
        #endregion

        public static int getHeightOfScreen => 720;
        public static int getWidthOfScreen => 1080;
    }
}
