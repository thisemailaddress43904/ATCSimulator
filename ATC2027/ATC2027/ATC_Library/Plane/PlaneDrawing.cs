using ATC2027.Controls;
using ATC2027.Controls.Shape;
using ATC2027.ExtensionClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Plane
{
    public partial class Plane
    {
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            head.Draw(gameTime, spriteBatch);
            tail.Draw(gameTime, spriteBatch);

            DrawTopLine(spriteBatch, ref head);
            DrawBottomLine(spriteBatch, ref head);
        }

        private void DrawBottomLine(SpriteBatch spriteBatch, ref Square planeHead)
        {
            var font = Constants.getArial_7();
            var location = planeHead.GetCentre();
            var str = getBottomLine();
            location.X -= font.MeasureString(str).X / 2;
            location.Y += font.MeasureString(str).Y / 2;

            if (isSelected)
            {
                Text.StaticDraw(spriteBatch, str, font, location, selectedTextDrawColor);
            }
            else
            {
                Text.StaticDraw(spriteBatch, str, font, location, normalTextDrawColor);
            }

        }

        private void DrawTopLine(SpriteBatch spriteBatch, ref Square planeHead)
        {
            var font = Constants.getArial_7();
            var location = planeHead.GetCentre();
            var topLine = getTopLine();

            var str = StringExtension.characterReplacer(topLine + topLine, ' ');


            location.X -= font.MeasureString(str).X / 2;
            location.Y -= font.MeasureString(str).Y;

            if (isSelected)
                Text.StaticDraw(spriteBatch, topLine, font, location, selectedTextDrawColor);
            else
                Text.StaticDraw(spriteBatch, topLine, font, location, normalTextDrawColor);
        }
    }
}
