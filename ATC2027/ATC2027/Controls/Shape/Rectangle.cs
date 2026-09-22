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
    public class Rectangle : MoveableItem
    {
        private int height;
        private int length;
        private Color color;
        private Vector2 centre;
        private float angle;
        private Texture2D texture;

        public Rectangle(int height, int length, Color color, Vector2 centre, float angle, GraphicsDevice graphicsDevice)
        {
            Texture2D CreateTexture(int height, int length, GraphicsDevice graphicsDevice, Color color)
            {
                Color[] colorArr = new Color[height * length];

                for (int i = 0; i < colorArr.Length; i++)
                {
                    colorArr[i] = color;
                }



                var t = new Texture2D(graphicsDevice, height, length);
                t.SetData(colorArr);

                return t;
            }

            this.height = height;
            this.length = length;
            this.color = color;
            this.centre = centre;
            this.angle = angle;
            this.texture = CreateTexture(height, length, graphicsDevice, color);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, base.position, color);
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
