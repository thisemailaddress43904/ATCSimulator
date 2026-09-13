using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATC2027.Controls.UserControl.Implementable
{
    public class Textbox : Label
    {
        private ColourScheme colourScheme => Constants.getColourScheme();
        bool isSelected;
        bool previousIsSelected;
        event Action? SelectionChanged;
        private static ICollection<Keys> keysToBeListenedTo = [Keys.Escape,
                Keys.Q, Keys.W, Keys.E, Keys.R, Keys.T, Keys.Y, Keys.U, Keys.I, Keys.O, Keys.P,
                Keys.A, Keys.S, Keys.D, Keys.F, Keys.G, Keys.H, Keys.J, Keys.K, Keys.L,
                Keys.Z, Keys.X, Keys.C, Keys.V, Keys.B, Keys.N, Keys.M,

                Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9,
        ];
        private ICollection<Task> keyListeningTasks;

        private ICollection<Task> setKeyListeningTasks()
        {
            KeyboardState ks = Keyboard.GetState();
            List<Task> tasks = new List<Task>();

            foreach (Keys key in keysToBeListenedTo)
            {
                tasks.Add(new Task(() => OnButtonPress(key)));
            }

            return tasks;
        }

        /// <summary>
        /// Accepts a character set of a-z0-9. No other characters will be accepted
        /// </summary>
        /// <param name="sf">sprite font</param>
        /// <param name="centre">centre</param>
        /// <param name="size">size</param>
        /// <param name="colors">colors</param>
        /// <param name="defaultValue">default value</param>
        public Textbox(SpriteFont sf, Vector2 centre, Vector2 size, ref Tuple<Color, Color, Color> colors, string defaultValue = "text") : base(defaultValue, sf, centre, size)
        {
            previousIsSelected = false;
            isSelected = false;
            keyListeningTasks = setKeyListeningTasks();
            
            SelectionChanged += OnSelectionChanged;
        }
        public override void Update(GameTime gameTime)
        {

            if (isSelected)
            {
                if (!base.outerRectangle.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    isSelected = false;
                }
            }
            else
            {
                if (base.outerRectangle.Contains(Mouse.GetState().Position) && Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    isSelected = true;
                }
            }

            if (isSelected != previousIsSelected)
            {
                Color oldPromaryColor = colourScheme.PrimaryColor;
                base.SetPrimaryColor(colourScheme.SecondaryColor);
                base.SetSecondaryColor(oldPromaryColor);

                previousIsSelected = isSelected;

                SelectionChanged?.Invoke();
            }


            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }

        public void OnButtonPress(Keys key)
        {
            if (Keyboard.GetState().IsKeyDown(key))
                base.SetContent(base.GetContent() + key.ToString());
        }

        public void OnSelectionChanged()
        {
            if (!isSelected)
                return;

            
            var keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Escape)) {
                isSelected = false;
                return;
            }
            if (keyboardState.IsKeyDown(Keys.Back))
            {
                string content = base.GetContent();
                base.SetContent(content.Substring(0, content.Length-2));
            }

            //all button clicks are listened to in parallel, this is much quicker than procedural
            //assuming that the foreach loop is not executed in parallel
            keyListeningTasks.All(t =>
            {
                t.Start();
                return true;
            });

            Task.WaitAll(keyListeningTasks.ToArray());

            /*
             * //this is procedural and could be done in parallel, this would be much quicker
            foreach (var key in Textbox.keysToBeListenedTo)
                OnButtonPress(ref keyboardState, key);
             * 
             */

        }
    }
}