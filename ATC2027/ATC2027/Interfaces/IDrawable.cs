using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATC2027.Interfaces
{
    public interface IDrawable
    {
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
