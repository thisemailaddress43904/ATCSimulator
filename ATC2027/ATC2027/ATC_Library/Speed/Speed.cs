using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Library.Speed
{
    public class Speed : ISpeed
    {
        private float knots;

        public Speed(float knots)
        {
            this.knots = knots;
        }

        public int ToKnots()
        {
            return (int)knots;
        }

        public ISpeed FromKnots()
        {
            return new Speed(knots);
        }

        public string ToString()
        {
            return ToKnots().ToString() + "kt";
        }

        public float ToKnotsFloat()
        {
            return (float)knots;
        }

        public ISpeed Increment(float val = 1)
        {
            return new Speed(knots + val);
        }

        public ISpeed Decrement(float val = 1) { 
            return new Speed(knots - val);
        }

        public static bool SpeedIsValid(ref string errorMessage, string str)
        {
            bool speedIsValid;
            //speed is larger than 0 and less than 400
            try
            {
                var val = Int128.Parse(str);

                speedIsValid = val < 400 && val > 50;
                if (!speedIsValid)
                    errorMessage = "speed was out of the range";

                return speedIsValid;
            }
            catch (Exception)
            {
                if (str != "")
                {
                    errorMessage = "speed was not a number";
                    return false;
                }
                return true;

            }
        }
    }
}
