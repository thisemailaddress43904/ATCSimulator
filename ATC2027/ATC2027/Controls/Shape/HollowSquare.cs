using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls.Shape
{
    public class HollowSquare : Square
    {
        int lineWidth;
        public HollowSquare(Vector2 topLeftCornerOfSquare, int length, GraphicsDevice graphicsDevice, Color? color = null, int lineWidth = 2) : base(topLeftCornerOfSquare, length, graphicsDevice, color)
        {
            this.lineWidth = lineWidth;
            base.lengthOfSquare = length;

            this.color = color == null ? Color.White : (Color)color;
            base.position = topLeftCornerOfSquare;
            textureLength = length;
            texture = CreateTexture(length, graphicsDevice, this.color);
        }
        public Texture2D CreateTexture(int length, GraphicsDevice graphicsDevice, Color color,
            int lineWidth = 0)
        {
            Color[] colorArr = new Color[length * length];

            //top row
            for (int x = 0; x < length * lineWidth; x++)
            {
                colorArr[x] = color;
            }
            //bottom row
            for (int x = (length - lineWidth) * length; x < length * length; x++)
            {
                colorArr[x] = color;
            }
            //left row
            for (int indentation = 0; indentation < lineWidth; indentation++)
                for (int x = 0; ; x += length)
                {
                    colorArr[x] = color;
                    if (x < length * length)
                        break;
                }
            //right row
            for (int indentation = length - lineWidth; indentation < lineWidth; indentation++)
                for (int x = 0; ; x += length)
                {
                    colorArr[x] = color;
                    if (x < length * length)
                        break;
                }

            var t = new Texture2D(graphicsDevice, length, length);
            t.SetData(colorArr);

            return t;
        }

    }
}
