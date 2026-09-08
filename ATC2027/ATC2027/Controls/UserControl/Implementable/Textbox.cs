using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls.UserControl.Implementable
{
    public class Textbox : Label
    {
        bool isSelected;
        bool previousIsSelected;

        
        /// <summary>
        /// Accepts a character set of a-z0-9. No other characters will be accepted
        /// </summary>
        /// <param name="sf">sprite font</param>
        /// <param name="centre">centre</param>
        /// <param name="size">size</param>
        /// <param name="colors">colors</param>
        /// <param name="defaultValue">default value</param>
        public Textbox(SpriteFont sf, Vector2 centre, Vector2 size, ref Tuple<Color, Color, Color> colors, string defaultValue = "text") : base(defaultValue, sf, centre, size, ref colors)
        {
            previousIsSelected = false;
            isSelected = false;
        }

        public override void Update(GameTime gameTime)
        {

            if (isSelected)
            {
                if (!base.outerRectangle.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    isSelected = false;
                }
            } else {
                if (base.outerRectangle.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    isSelected = true;
                }
            }
            

            if (isSelected != previousIsSelected)
            {
                Color oldPromaryColor = GetPrimaryColor();
                base.SetPrimaryColor(GetSecondaryColor());
                base.SetSecondaryColor(oldPromaryColor);

                if (isSelected)
                {
                    //subscribe key board clicks

                }
                else
                {
                    //unsubscribe key board clicks

                }
            }

            previousIsSelected = isSelected;
            base.Update(gameTime);
        }


    }
}
