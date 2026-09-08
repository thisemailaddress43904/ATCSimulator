using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls.Shape
{
    /// <summary>
    /// Represents a moveable square item that can be drawn and updated within a game environment.
    /// </summary>
    /// <remarks>The Square class provides functionality for rendering a square of a specified size and color,
    /// and allows movement based on keyboard input. It inherits from MoveableItem, enabling position updates and
    /// integration with game loops. The square's texture is generated at construction, and its location and center can
    /// be queried for gameplay or rendering purposes.</remarks>
    public class Square : MoveableItem
    {
        protected Texture2D texture;
        protected int textureLength;
        protected int lengthOfSquare;
        protected Color color;
        public Square(Vector2 topLeftCornerOfSquare, int length, GraphicsDevice graphicsDevice, Color? color = null)
        {
            this.lengthOfSquare = length;

            this.color = color == null ? Color.White : (Color)color;
            base.position = topLeftCornerOfSquare;
            textureLength = length;
            texture = CreateTexture(length, graphicsDevice, this.color);
        }
        public Int64? GetSize() => textureLength;

        public Texture2D CreateTexture(int length, GraphicsDevice graphicsDevice, Color color)
        {
            Color[] colorArr = new Color[length * length];
            
            for (int i = 0; i < colorArr.Length; i++)
            {
                colorArr[i] = color;
            }
                


            var t = new Texture2D(graphicsDevice, length, length);
            t.SetData(colorArr);
            
            return t;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, base.position, color);
        }

        public override void Update(GameTime gameTime)
        {
            bool allowArrowControlOverPlane = false;

            if (allowArrowControlOverPlane)
            {
                float multiplier = 0.15f;
                float constant = 1f;

                float movementAmount = multiplier * constant;

                bool down = Keyboard.GetState().IsKeyDown(Keys.Down);
                bool up = Keyboard.GetState().IsKeyDown(Keys.Up);
                bool left = Keyboard.GetState().IsKeyDown(Keys.Left);
                bool right = Keyboard.GetState().IsKeyDown(Keys.Right);

                float totalYMovement = (up ? -movementAmount : 0) + (down ? movementAmount : 0);
                float totalXMovement = (left ? -movementAmount : 0) + (right ? movementAmount : 0);

                //see if the square should move diagonally
                if (totalYMovement != 0f && totalXMovement != 0f)
                {
                    // enable diagonal movement at roughly same speed as horizontal/vertical movement - needs to be exact at some point
                    totalXMovement /= 2;
                    totalYMovement /= 2;
                }
    
                this.IncrementLocation(totalXMovement, totalYMovement);
            }
            
        }

        public Vector2 GetLocation()
        {
            return base.position;
        }

        public Vector2 GetCentre()
        {
            return base.position + new Vector2(this.lengthOfSquare / 2, this.lengthOfSquare / 2);
        }

        internal int getLength()
        {
            return this.lengthOfSquare; 
        }

        public void SetCentre(Vector2 newCentreOfHead)
        {
            base.position = new Vector2(newCentreOfHead.X - this.lengthOfSquare / 2, newCentreOfHead.Y - this.lengthOfSquare / 2);
        }

        internal void SetColor(Color color)
        {
            this.color = color;
        }
    }
}