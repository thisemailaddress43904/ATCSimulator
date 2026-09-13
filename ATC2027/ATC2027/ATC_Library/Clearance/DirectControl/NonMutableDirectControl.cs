using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Library.FlightNumber;

namespace ATC2027.Clearance.DirectControl
{
    public class NonMutableDirectControl : DirectControl2
    {
        public NonMutableDirectControl(FlightNumber flightNumber, string AreaControllerIdentifier, IAltitude altitude, IHeading heading, ISpeed speed, IRunway expectedRunway) : base(flightNumber, AreaControllerIdentifier, speed, altitude, heading, expectedRunway)
        {
        }

        public NonMutableDirectControl(ADirectControl aDirectControl)
        {

        }

        public override ADirectControl ApplyAltitude(IAltitude altitude)
        {
            throw new System.NotImplementedException();
        }

        public override ADirectControl ApplyHeading(IHeading heading)
        {
            throw new System.NotImplementedException();
        }

        public override ADirectControl ApplySpeed(ISpeed speed)
        {
            throw new System.NotImplementedException();
        }
    }
}
