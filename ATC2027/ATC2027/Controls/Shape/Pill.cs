using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls.Shape
{
    public class Pill : IComponent
    {

        public Pill(int pillHeight, int pillLengthAtLongestPoint, Vector2 centreOfPill, Color color, GraphicsDevice graphicsDevice)
        {
            if (pillLengthAtLongestPoint < pillHeight * 2)
            {
                //idk how to handle this, the pill would have pointy edges out of the side
                throw new ArgumentException("Illegal paramaters, pillHeight must be atleast half of pillLengthAtLongestPoint");
            }
            this.color = color;
            this.rectangle = new RectangleShape(
                pillHeight, 
                (int)(pillLengthAtLongestPoint - pillHeight * 2), 
                color, 
                new Vector2(pillHeight/2, 0), 
                0, 
                graphicsDevice);
            this.leftCircle = new Circle(
                new Vector2(), 
                pillHeight / 2, color, 
                graphicsDevice);
            this.rightCircle = new Circle(
                new Vector2(pillHeight / 2 + pillLengthAtLongestPoint,0), 
                pillHeight / 2, 
                color, graphicsDevice);
        }

        Color color;
        Vector2 centre;
        Circle leftCircle;
        Circle rightCircle;
        RectangleShape rectangle;

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            leftCircle.Draw(gameTime, spriteBatch);
            rightCircle.Draw(gameTime, spriteBatch);
            rectangle.Draw(gameTime, spriteBatch);
        }

        public void Update(GameTime gameTime)
        {
            
        }
    }
}
