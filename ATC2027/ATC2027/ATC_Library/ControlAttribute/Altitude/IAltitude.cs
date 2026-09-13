using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.ControlAttribute.Altitude
{
    public interface IAltitude
    {
        public int GetAltitudeInFeet();
        public string GetAltitudeAsFlightLevel(int NumberOfDigitsAfterDecimalPoint = 0);
        public string ToString();
        IAltitude Decrement(float rateOfDescentPerPeriod);
        IAltitude Increment(float rateOfDescentPerPeriod);
    }
}
