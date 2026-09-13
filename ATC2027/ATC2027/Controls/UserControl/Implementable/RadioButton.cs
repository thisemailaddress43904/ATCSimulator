using ATC2027.Controls.UserControl.Abstract;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls.UserControl.Implementable
{
    public class RadioButton : IRadioButton
    {
        ColourScheme colourScheme;
        SpriteFont spriteFont;
        Vector2 firstItemCentre;
        Vector2 size;
        private IList<RadioButtonItem> items;
        
        public string? getLabelContentOfSelectedRadioButton()
        {
            foreach (RadioButtonItem item in items) {
                if (item.IsSelected())
                    return item.getLabelContent();
            }
            return null;
        }

        private float getSpacing()
        {
            return ((float)this.spriteFont.LineSpacing * 1.05f);
        }

        public class RadioButtonItem : Interfaces.IDrawable, Interfaces.IUpdateable
        {
            Texture2D on, off;
            Vector2 topLeftCorner;
            int spacingBetweenTextureAndLabel = 5;
            int widthOfTexture = 25;
            Label label;
            bool isSelected;
            ColourScheme colourScheme;

            public RadioButtonItem(string text, SpriteFont sf, Vector2 centre, Vector2 size, Texture2D on, Texture2D off)
            {
                this.label = new Label(text, sf, centre, size);
                this.on = on;
                this.off = off;
                this.isSelected = false;
                this.colourScheme = colourScheme;
            }

            public void ToggleSelection()
            {
                isSelected = !isSelected;
            }
            public void setIsSelected(bool selected)
            {
                isSelected = selected;
            }

            public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
            {
                spriteBatch.Draw(isSelected ? on : off, topLeftCorner, Color.White);
                label.Draw(gameTime, spriteBatch);
            }

            public void Update(GameTime gameTime)
            {
                label.Update(gameTime);
            }

            internal string getLabelContent()
            {
                return label.GetContent();
            }

            internal bool IsSelected()
            {
                return isSelected;
            }
        }

        public RadioButton(ICollection<string> strings, Texture2D on, Texture2D off, SpriteFont spriteFont, Vector2 firstItemCentre, Vector2 sizeOfLabel, ref ColourScheme colourScheme)
        {
            this.firstItemCentre = firstItemCentre;
            this.size = sizeOfLabel;
            this.colourScheme = colourScheme;

            items = new List<RadioButtonItem>();

            ColourScheme cs = Constants.getColourScheme();
            foreach (string s in strings)
            {
                items.Add(new RadioButtonItem(s, spriteFont, new Vector2(firstItemCentre.X * (items.Count * getSpacing()), firstItemCentre.Y), sizeOfLabel, on, off));
            }
        }
        

        public void SelectItemAt(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            for (int i = 0; i < items.Count; i++)
            {
                items[i].setIsSelected(false);
            }
            
            items[index].setIsSelected(true);
        }

        public void SelectItem()
        {
            
        }

        public int GetNumberOfItems()
        {
            return items.Count;
        }

        public bool IsActive()
        {
            return true;
        }

        public bool IsVisible()
        {
            return true;
        }

        public bool ShouldBeDrawn()
        {
            return true;
        }

        public bool IsSelected()
        {
            return true;
        }

        public void Update(GameTime gameTime)
        {
            foreach (RadioButtonItem item in items)
            {
                item.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (RadioButtonItem item in items)
            {
                item.Draw(gameTime, spriteBatch);
            }
        }
    }
}
