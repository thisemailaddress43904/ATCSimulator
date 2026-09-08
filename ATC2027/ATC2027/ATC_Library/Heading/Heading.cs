using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ATC2027.ATC_Library.Heading
{
    public class Heading : IHeading
    {
        private float v;

        public Heading(float v)
        {
            this.v = v;
        }

        public Heading(string text)
        {
            if (!float.TryParse(text, out v))
                throw new ArgumentException($"Could not convert {nameof(text)} to a float value. {nameof(text)} had the value {text}"); 
        }

        public Heading(IHeading heading)
        {
            this.v = heading.GetHeadingInFloatDegrees();
        }

        public IHeading Decrement(float val = 1f)
        {
            return new Heading(this.v-val);
        }

        public float GetHeadingInFloatDegrees()
        {
            return v;
        }

        public int GetHeadingInIntegerDegrees()
        {
            return (int)v;

        }

        public IHeading Increment(float val = 1f)
        {
            return new Heading(v+val);
        }

        public override string ToString() { 
            string str = v.ToString();
            str = str.Trim().Split(".")[0];
            
            while (str.Length < 3) 
                str = "0" + str;
            
            return str;
        }

        internal float GetHeadingInFloatRadians()
        {
            return MathHelper.ToRadians(v-90);
        }

        double IHeading.GetHeadingInFloatRadians()
        {
            return GetHeadingInFloatRadians();
        }

        public static Heading operator ++(Heading operand)
        {
            float currentHeadingAsFloat = operand.GetHeadingInFloatDegrees();
            currentHeadingAsFloat += 1;
            currentHeadingAsFloat %= 360;
            return new Heading(currentHeadingAsFloat);
        }
        public static Heading operator --(Heading operand)
        {
            float currentHeadingAsFloat = operand.GetHeadingInFloatDegrees();
            currentHeadingAsFloat -= 1;
            
            while (currentHeadingAsFloat < 0)
            {
                currentHeadingAsFloat += 360;
            }

            return new Heading(currentHeadingAsFloat);
        }
        public static bool HeadingIsValid(ref string errorMessage, string text)
        {
            //heading is an integer larger than -1 and smaller than 361
            bool headingIsOutsideTheRange;
            bool isValid;
            try
            {
                var val = Int128.Parse(text);
                headingIsOutsideTheRange = !(val < 361 && val > -1);

                if (headingIsOutsideTheRange)
                {
                    errorMessage = "heading was outside the range";
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                var result = (text == "");

                if (!result)
                    errorMessage = "heading was not a number";

                return result;
            }
        }
    }
}
