using ATC2027.Clearance;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance.WaypointControl
{
    public abstract class AWaypointClearance : IClearance, IHasExpectedRunway
    {
        public abstract IClearance FromAirTrafficControllerDescription(string description, bool isMutable);
        public abstract string GetAirTrafficControllingTowerIdentifier();
        public abstract string getDevModeDrawableString();
        public abstract IRunway getExpectedRunway();
        public abstract FlightNumber GetFlightNo();
        public abstract void setExpectedRunway(IRunway expectedRunway, IAirfield airfield);
        public abstract string ToAirTrafficControllerDescription();
        public abstract bool WithNoDelay();
    }
}
