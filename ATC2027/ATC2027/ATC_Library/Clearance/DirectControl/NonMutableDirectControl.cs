using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Library.FlightNumber;
using System;
using System.Text;

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
            StringBuilder sb = new StringBuilder();
            sb.Append(base.AreaControllerIdentifier).Append(' ').Append(base.FlightNumber).Append(" cleared to ");

            if (base.altitude != null)
                sb.Append("flight level ").AppendLine(base.altitude.GetAltitudeAsFlightLevel());
            if (base.heading != null)
                sb.Append(base.heading).AppendLine(" degrees");
            if (base.speed != null)
                sb.Append(base.speed.ToString()).AppendLine(" knots");

            return sb.ToString();
        }

        public Heading getTargetHeading()
        {
            return this.heading;
        }

        public Altitude getTargeAltitude()
        {
            return this.altitude;
        }

        public Speed getTargetSpeed()
        {
            return this.speed;
        }
    }
}
