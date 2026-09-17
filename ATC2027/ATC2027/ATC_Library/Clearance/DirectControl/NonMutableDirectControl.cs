using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Library.FlightNumber;

namespace ATC2027.Clearance.DirectControl
{
    public class NonMutableDirectControl : DirectControl2, INonMutableClearance
    {
        public NonMutableDirectControl(FlightNumber flightNumber, string AreaControllerIdentifier, IAltitude altitude, IHeading heading, ISpeed speed, IRunway expectedRunway) : base(flightNumber, AreaControllerIdentifier, speed, altitude, heading, expectedRunway)
        {
        }

        public NonMutableDirectControl(ADirectControl aDirectControl) : base(aDirectControl.GetFlightNo(), aDirectControl.GetAirTrafficControllingTowerIdentifier(), aDirectControl.GetSpeed(), aDirectControl.GetAltitude(), aDirectControl.GetHeading(), aDirectControl.GetExpectedRunway())
        {
            
        }

        public override ADirectControl ApplyAltitude(IAltitude altitude)
        {
            base.altitude = altitude;
            return this;
        }

        public override ADirectControl ApplyHeading(IHeading heading)
        {
            base.heading = heading; 
            return this;
        }

        public override ADirectControl ApplySpeed(ISpeed speed)
        {
            base.speed = speed;
            return this;
        }

        public override IAltitude GetAltitude()
        {
            return base.altitude;
        }

        public override IHeading GetHeading()
        {
            return base.heading;
        }

        public override ISpeed GetSpeed()
        {
            return base.speed;
        }

        public override IRunway GetExpectedRunway()
        {
            return base.expectedRunway;
        }
    }
}
