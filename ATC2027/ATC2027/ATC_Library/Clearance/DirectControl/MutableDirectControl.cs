using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Library.FlightNumber;
using System;

namespace ATC2027.Clearance.DirectControl
{
    public class MutableDirectControl : DirectControl2, IMutableClearance
    {
        public MutableDirectControl(FlightNumber flightNumber, string AreaControllerIdentifier, IAltitude? altitude, IHeading heading, ISpeed speed, IRunway expectedRunway) : base(flightNumber, AreaControllerIdentifier, speed, altitude, heading, expectedRunway)
        {

        }

        public MutableDirectControl(ADirectControl directControl)
        {
            
        }

        public MutableDirectControl()
        {

        }

        public static MutableDirectControl getEmptyClearance() => new MutableDirectControl();

        public override ADirectControl ApplyAltitude(IAltitude altitude)
        {
            throw new NotImplementedException();
        }

        public override ADirectControl ApplyHeading(IHeading heading)
        {
            throw new NotImplementedException();
        }

        public override ADirectControl ApplySpeed(ISpeed speed)
        {
            throw new NotImplementedException();
        }
    }
}
