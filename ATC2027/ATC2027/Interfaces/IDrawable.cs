using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATC2027.Interfaces
{
    public interface IDrawable
    {
        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
