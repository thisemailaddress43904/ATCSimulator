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

        private ColourScheme colourScheme;

        public Label(string label, SpriteFont sf, Vector2 centre, Vector2 size, ref ColourScheme colourScheme)
        {

            this.colourScheme = colourScheme;

            this.centre = centre;
            this.text = new Text(label, sf, centre, ref colourScheme, 3);

        }


        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (!shouldBeDrawn)
                return;

            spriteBatch.Draw(outerRectangleTexture, outerRectangle, colourScheme.PrimaryColor);
            spriteBatch.Draw(innerRectangleTexture, innerRectangle, colourScheme.SecondaryColor);
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
            return colourScheme.PrimaryColor;
        }

        public Color GetSecondaryColor()
        {
            return colourScheme.SecondaryColor;
        }

        public Color GetTertiaryColor()
        {
            return colourScheme.TertiaryColor;
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
    }
}
