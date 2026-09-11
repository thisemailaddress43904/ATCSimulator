using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Controls
{
    public class ColourScheme
    {
        internal static int maxNumberOfColours = 5;
        internal static int minNumberOfColours = 0;
        public Color PrimaryColor { get; private set; }
        public Color SecondaryColor { get; private set; }
        public Color TertiaryColor { get; private set; }
        public Color QuarternaryColor { get; private set; }
        public Color QuintineryColor { get; private set; }

        public ColourScheme(Tuple<Color, Color, Color, Color, Color> colorTuple)
        {
            this.PrimaryColor = colorTuple.Item1;
            this.SecondaryColor = colorTuple.Item2;
            this.TertiaryColor = colorTuple.Item3;
            this.QuarternaryColor = colorTuple.Item4;
            this.QuintineryColor = colorTuple.Item5;
        }

        public ColourScheme(Color primaryColor, Color secondaryColor, Color tertiaryColor, Color quarternaryColor, Color quintinaryColor)
        {
            this.PrimaryColor = primaryColor;
            this.SecondaryColor = secondaryColor;
            this.TertiaryColor = tertiaryColor;
            this.QuarternaryColor = quarternaryColor;
            this.QuintineryColor = quintinaryColor;
        }

        public Color? ItemAt(int colourSchemeIndex)
        {
            switch (colourSchemeIndex)
            {
                case 0: return this.PrimaryColor;
                case 1: return this.SecondaryColor;
                case 2: return this.TertiaryColor;
                case 3: return this.QuarternaryColor;
                case 4: return this.QuintineryColor;
                default: return null;
            }
        }
    }
}
