using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Interfaces
{
    public interface IUpdateable
    {
        public abstract void Update(GameTime gameTime);
    }
}
