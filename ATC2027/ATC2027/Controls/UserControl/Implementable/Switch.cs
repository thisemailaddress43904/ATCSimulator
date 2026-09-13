using ATC2027.Controls.UserControl.Abstract;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace ATC2027.Controls.UserControl.Implementable
{
    public class Switch : ISwitch
    {
        private Texture2D on, off;
        private Tuple<Color, Color, Color> colorTuple;
        private bool isOn;
        private Label label;
        private int spaceBetweenLabelAndTexture = 5;
        private Vector2 topLeftCornerOfTexture;
        private Rectangle outerRectangle;
        private Texture2D outerRectangleTexture;

        public Switch(Texture2D on, Texture2D off, bool isOn, string labelContent, SpriteFont spriteFont, Vector2 topLeftCornerOfOuterRectangle)
        {
            this.label = new Label(labelContent, spriteFont, new Vector2(), new Vector2(40, 225));
            this.isOn = isOn;
            this.on = on;
            this.off = off;
            this.outerRectangle = new Rectangle((int)topLeftCornerOfOuterRectangle.X, (int)topLeftCornerOfOuterRectangle.Y, 40, 225);
            this.colorTuple = colorTuple;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(outerRectangleTexture, outerRectangle, Color.Gray);
            spriteBatch.Draw(isOn ? on : off, topLeftCornerOfTexture, Color.Transparent);
            label.Draw(gameTime, spriteBatch);
        }

        public string GetLabelContent()
        {
            return label.GetContent();
        }

        public Color GetPrimaryColor()
        {
            return colorTuple.Item1;
        }

        public Color GetSecondaryColor()
        {
            return colorTuple.Item2;
        }

        public Color GetTertiaryColor()
        {
            return colorTuple.Item3;
        }

        public bool IsActive()
        {
            return true;
        }

        public bool IsSelected()
        {
            return false;
        }

        public bool IsSetToTrue()
        {
            return isOn;
        }

        public bool IsVisible()
        {
            return true;
        }

        public void SetLabelContent(string str)
        {
            this.label.SetContent(str);
        }

        public bool ShouldBeDrawn()
        {
            return true;
        }

        public void Update(GameTime gameTime)
        {
            label.Update(gameTime);
        }
    }
}
