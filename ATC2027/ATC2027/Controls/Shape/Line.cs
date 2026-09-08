using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Text;

namespace ATC2027.Controls.Shape
{
    /// <summary>
    /// Represents a drawable line component with configurable start and end points, color, and thickness.
    /// </summary>
    /// <remarks>The Line class is used to render a straight line between two points in a 2D space. It
    /// supports updating its color and thickness, and can be drawn using a SpriteBatch. The line is only drawn when
    /// both start and end points are set. This class is typically used in graphical applications or games that require
    /// custom line rendering.</remarks>
    public class Line : IComponent
    {
        protected Vector2? start;
        protected Vector2? end;

        protected bool texturesShouldBeUpdated => (start != null && end != null) && (startOrEndHasChanged || colorHasChanged);
        protected Texture2D texture;

        protected int thickness;
        protected Color drawColor;

        private Vector2 origin;
        private float rotation;

        bool startOrEndHasChanged;
        bool colorHasChanged;

        public Line(Vector2? start = null, Vector2? end = null, Color? drawColor = null, int thickness = 1) {
            this.start = start;
            this.end = end;
            this.thickness = thickness;
            this.drawColor = drawColor ?? Color.White;
            this.startOrEndHasChanged = true;
            this.colorHasChanged = true;
        }

        public void SetColor(Color color)
        {
            this.drawColor = color;
            this.colorHasChanged = true;
        }

        public virtual void Update(GameTime gameTime)
        {
            if (texturesShouldBeUpdated)
                UpdateTexture();
            
        }

        private void UpdateTexture()
        {
            if (this.texturesShouldBeUpdated)
            {
                //remove nullable possibility from end and start
                var end = (Vector2)this.end;
                var start = (Vector2)this.start;

                if (end == start)
                {
                    texture = null;
                    return;
                }


                // Create a texture as wide as the distance between two points and as high as
                // the desired thickness of the line.

                var distance = (int)Vector2.Distance(start, end);

                //handle the distance between the start and the end being 0 when converted to an integer
                if (distance == 0)
                {
                    texture = null;
                    return;
                }

                texture = new Texture2D(Constants.spriteBatch.GraphicsDevice, distance, thickness);

                // Fill texture with given color.
                var data = new Color[distance * thickness];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = drawColor;
                }
                texture.SetData(data);
                
                // Rotate about the beginning middle of the line.
                rotation = (float)Math.Atan2(end.Y - start.Y, end.X - start.X);
                origin = new Vector2(0, thickness / 2);


                this.colorHasChanged = false;
                this.startOrEndHasChanged = false;
            }
        }

        public bool ShouldBeDrawn()
        {
            //the line should be drawn when neither the start or end is null
            return this.start != null && this.end != null;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            if (end == null || start == null)
                return;

            if (texture != null)
            {
                var start = (Vector2)this.start;
                spriteBatch.Draw(texture, start, null, drawColor, rotation, origin, 1.0f, SpriteEffects.None, 1.0f);
            }
                
        }
        public void SetStart(Vector2? value)
        {
            this.start = value;
            var a = 2;
        }
        public void SetEnd(Vector2? value)
        {
            this.end = value;
            var a = 2;
        }

        public string getDevModeDrawableString(bool includeStart, bool includeEnd, bool includeWidth = false)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("line");
            if (includeStart)
                sb.AppendLine($"\tstart?: {(start != null ? start.Value : "null")}");
            if (includeEnd)
                sb.AppendLine($"\tend?: {(end != null ? end.Value : "null")}");
            if (includeWidth)
                sb.AppendLine($"\twidth: {this.thickness}");

            return sb.ToString();
        }

        public string getDevModeDrawableString()
        {
            return getDevModeDrawableString(true, true, false);
        }

        internal string GetStartAsEnd()
        {
            return this.end == null ? "null" : this.end.ToString();
        }

        internal string GetStartAsString()
        {
            return this.start == null ? "null" : this.start.ToString();
        }
    }
}
