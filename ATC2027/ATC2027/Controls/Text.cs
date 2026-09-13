using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

using IDrawable = ATC2027.Interfaces.IDrawable;
using System;

namespace ATC2027.Controls
{
    /// <summary>
    /// Represents a drawable text element with customizable font, position, and color for rendering in a monogame window
    /// </summary>
    /// <remarks>The Text class implements the IDrawable interface, allowing instances to be rendered using a
    /// SpriteBatch. The color parameter supports transparency, enabling effects such as faded or highlighted text.
    /// Thread safety is not guaranteed; modifications to properties should be performed on the main thread.</remarks>
    /// <param name="text">The string to display as the text content.</param>
    /// <param name="spriteFont">The font used to render the text.</param>
    /// <param name="location">The position, in screen coordinates, where the text will be drawn. If not specified, defaults to (35, 35).</param>
    /// <param name="color">The color used to render the text. If not specified, defaults to black with half opacity.</param>
    public class Text(string text, SpriteFont spriteFont, Vector2 location) : IDrawable
    {
        private ColourScheme colourScheme => Constants.getColourScheme();

        string text = text;
        SpriteFont spriteFont = spriteFont;
        Vector2 location = location;
        

        public void setText(string newText) => this.text = newText;
        public string getText() => this.text;

        public void setSpriteFont(SpriteFont spriteFont) => this.spriteFont = spriteFont;
        public SpriteFont getSpriteFont() => this.spriteFont;

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(spriteFont, text, location, this.colourScheme.PrimaryColor);
        }
        /// <summary>
        /// Draws text with the given parameters. If location or color are not given, they will default to (35,35) and black respectively.
        /// </summary>
        /// <param name="spriteBatch"></param>
        /// <param name="text"></param>
        /// <param name="spriteFont"></param>
        /// <param name="location"></param>
        /// <param name="color"></param>
        public static void StaticDraw(SpriteBatch spriteBatch, string text, SpriteFont spriteFont, Vector2? location = null, Color? color = null)
        {
            if (location == null)
                location = new Vector2(35, 35);

            if (color == null)
                color = Color.Black;
            try
            {
                spriteBatch.DrawString(spriteFont, text, (Vector2)location, (Color)color);
            }
            catch (Exception)
            {
                spriteBatch.DrawString(spriteFont, "?", (Vector2)location, (Color)color);
            }
            
        }
    }
}
