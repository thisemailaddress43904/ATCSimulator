using ATC2027.Controls.UserControl.Abstract;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;


namespace ATC2027.Controls.UserControl.Implementable
{
    public class Label : ILabel
    {
        bool isActive;
        bool isSelected;
        bool isVisible;
        bool shouldBeDrawn;

        protected Rectangle outerRectangle, innerRectangle;
        Texture2D outerRectangleTexture, innerRectangleTexture;
        Text text;
        private Vector2 centre;

        private Color primaryColor, secondaryColor, tertiaryColor;

        public Label(string label, SpriteFont sf, Vector2 centre, Vector2 size, ref Tuple<Color, Color, Color> colors)
        {

            this.primaryColor = colors.Item1;
            this.secondaryColor = colors.Item2;
            this.tertiaryColor = colors.Item3;

            this.centre = centre;
            this.text = new Text(label, sf, centre, tertiaryColor);

        }


        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (!shouldBeDrawn)
                return;

            spriteBatch.Draw(outerRectangleTexture, outerRectangle, primaryColor);
            spriteBatch.Draw(innerRectangleTexture, innerRectangle, secondaryColor);
            text.Draw(gameTime, spriteBatch);

        }

        public string GetContent()
        {
            return this.text.getText();
        }

        public void SetContent(string newContnet)
        {
            this.text.setText(newContnet);
        }

        public Color GetPrimaryColor()
        {
            return primaryColor;
        }

        public Color GetSecondaryColor()
        {
            return secondaryColor;
        }

        public Color GetTertiaryColor()
        {
            return tertiaryColor;
        }

        public bool IsActive()
        {
            return isActive;
        }

        public bool IsSelected()
        {
            return isSelected;
        }

        public bool IsVisible()
        {
            return isVisible;
        }

        public bool ShouldBeDrawn()
        {
            return shouldBeDrawn;
        }

        public virtual void Update(GameTime gameTime)
        {
            if (!shouldBeDrawn)
                return;
        }

        internal void SetPrimaryColor(Color color)
        {
            this.primaryColor = color;
        }

        internal void SetSecondaryColor(Color oldPromaryColor)
        {
            this.secondaryColor = oldPromaryColor;
        }
    }
}
