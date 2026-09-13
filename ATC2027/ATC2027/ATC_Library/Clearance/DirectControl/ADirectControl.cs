using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Library.FlightNumber;
using System;

namespace ATC2027.ATC_Library.Clearance.DirectControl
{
    public abstract class ADirectControl : IClearance
    {
        public abstract ADirectControl ApplyHeading(IHeading heading);
        public abstract ADirectControl ApplySpeed(ISpeed speed);
        public abstract ADirectControl ApplyAltitude(IAltitude altitude);
        public abstract bool WithNoDelay();
        public abstract string ToAirTrafficControllerDescription();
        public abstract IClearance FromAirTrafficControllerDescription(string description, bool isMutable);
        public abstract FlightNumber GetFlightNo();
        public abstract string GetAirTrafficControllingTowerIdentifier();
        
    }
}