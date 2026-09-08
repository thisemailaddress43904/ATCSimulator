using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.State
{
    public class Loading : AState
    {
        public string Name => "loading";

        public override string getName => this.GetType().Name;

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
            base.Draw(gameTime, spriteBatch);
        }

        public override string getDevModeDrawableString()
        {
            return "currentState: loading";
        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }
    }
}
