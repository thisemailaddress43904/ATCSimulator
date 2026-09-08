using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Library.Altitude
{
    public interface IAltitude
    {
        public int GetAltitudeInFeet();
        public string GetAltitudeAsFlightLevel(int NumberOfDigitsAfterDecimalPoint);
        public string ToString();
        IAltitude Decrement(float rateOfDescentPerPeriod);
        IAltitude Increment(float rateOfDescentPerPeriod);
    }
}
