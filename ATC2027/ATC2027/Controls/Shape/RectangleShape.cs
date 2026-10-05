using ATC2027.Interfaces;
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
    public class RectangleShape : IComponent
    {
        private int height;
        private int length;
        private Color color;
        private Vector2 centre;
        private float angle;
        private Texture2D texture;
        private Vector2 topLeftCorner => new Vector2(centreOfRotation.X - length / 2, centreOfRotation.Y - height / 2);
        private Vector2 centreOfRotation = new Vector2(Constants.getWidthOfScreen / 2, Constants.getHeightOfScreen / 2);

        public RectangleShape(int height, int length, Color color, Vector2 centre, float angle, GraphicsDevice graphicsDevice)
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

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Rectangle positionOfRectangle = new Rectangle((int)(topLeftCorner.X + this.centre.X), (int)(topLeftCorner.Y + this.centre.Y), length, height);
            Rectangle drawWindow = new Rectangle(0, 0, length, height);
            centreOfRotation = new Vector2(positionOfRectangle.X + centre.X / 2, positionOfRectangle.Y + centre.Y / 2);


            spriteBatch.Draw(
                texture,
                positionOfRectangle, 
                drawWindow, 
                color, 
                (float)double.DegreesToRadians(angle), 
                centreOfRotation, 
                SpriteEffects.None, 
                1f);
        }
        
        public void Update(GameTime gameTime)
        {
            
        }
    }
}