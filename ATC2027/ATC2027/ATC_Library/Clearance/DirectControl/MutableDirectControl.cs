using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Specialized;

namespace ATC2027.Clearance.DirectControl
{
    public class MutableDirectControl : DirectControl2, IMutableClearance
    {
        public MutableDirectControl(FlightNumber flightNumber, string AreaControllerIdentifier, IAltitude? altitude, IHeading heading, ISpeed speed, IRunway expectedRunway) : base(flightNumber, AreaControllerIdentifier, (Speed)speed, (Altitude)altitude, (Heading)heading, expectedRunway)
        {}

        public MutableDirectControl(ADirectControl directControl) : base(directControl.GetFlightNo(), directControl.GetAirTrafficControllingTowerIdentifier(), directControl.GetSpeed(), directControl.GetAltitude(), directControl.GetHeading(), directControl.GetExpectedRunway())
        {}

        public MutableDirectControl()
        {}

        public static MutableDirectControl getEmptyClearance() => new MutableDirectControl();

        public override ADirectControl ApplyAltitude(IAltitude altitude)
        {
            base.altitude = (Altitude)altitude;
            return this;
        }

        public override ADirectControl ApplyHeading(IHeading heading)
        {
            base.heading = (Heading)heading;
            return this;
        }

        public override ADirectControl ApplySpeed(ISpeed speed)
        {
            base.speed = (Speed)speed;
            return this;
        }

        public override Altitude GetAltitude()
        {
            return base.altitude;
        }

        public override Heading GetHeading()
        {
            return base.heading;
        }

        public override Speed GetSpeed()
        {
            return base.speed;
        }

        public override IRunway GetExpectedRunway()
        {
            return base.expectedRunway;
        }

        public override string getDevModeDrawableString()
        {
            throw new NotImplementedException();
        }
    }
}
