using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027
{
    public abstract class MoveableItem : IComponent
    {
        protected Vector2 position;

        public void SetLocation(float x, float y)
        {
            position = new Vector2(x, y);
        }

        public void IncrementLocation(float deltaX, float deltaY)
        {
            position.X += deltaX;
            position.Y += deltaY;
        }
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
