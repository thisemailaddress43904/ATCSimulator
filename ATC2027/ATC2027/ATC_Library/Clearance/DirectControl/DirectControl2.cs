

using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Library.FlightNumber;
using System;
using System.Text;

namespace ATC2027.Clearance
{
    public abstract class DirectControl2 : ADirectControl
    {
        protected IRunway? expectedRunway;
        protected FlightNumber? FlightNumber;
        protected string? AreaControllerIdentifier;
        protected ISpeed? speed;
        protected IAltitude? altitude;
        protected IHeading? heading;

        public DirectControl2()
        {
            this.FlightNumber = null;
            this.AreaControllerIdentifier = null;
            this.speed = null;
            this.altitude = null;
            this.heading = null;
            this.expectedRunway = null;
        }

        public DirectControl2(FlightNumber flightNumber, string AreaControllerIdentifier, ISpeed? speed, IAltitude? altitude, IHeading? heading, IRunway? expectedRunway)
        {
            this.expectedRunway = expectedRunway;
            this.FlightNumber = flightNumber;
            this.AreaControllerIdentifier = AreaControllerIdentifier;
            this.speed = speed;
            this.altitude = altitude;
            this.heading = heading;
        }

        public override string ToAirTrafficControllerDescription()
        {
            //return "" if all control attributes are null as no clearance needs to be issued as there's no alterations
            if (speed == null && altitude == null && heading == null)
                return "";

            StringBuilder sb = new StringBuilder();
            sb.Append($"{FlightNumber} {AreaControllerIdentifier} cleared to ");

            
            if (speed != null)
            {
                sb.Append(speed.ToKnots()).Append(" knots");

                //add formatting space
                if (heading != null || altitude != null)
                    sb.Append(' ');

            }
            if (heading != null)
            {
                sb.Append("heading ");
                sb.Append(heading.GetHeadingInFloatDegrees());

                //add formatting space
                if (altitude != null)
                    sb.Append(' ');

            }            
            if (altitude != null)
            {
                sb.Append("flight level ");
                sb.Append(altitude.GetAltitudeAsFlightLevel());
            }

            return sb.ToString();
        }
        public override IClearance FromAirTrafficControllerDescription(string description, bool isMutable)
        {
            var splitDescription = description.Split(" cleared to ");
            var splitCallSigns = splitDescription[0].Split(" ");

            return DirectControlClearanceFactory.BuildDirectControlClearance(isMutable, new FlightNumber(splitCallSigns[0]), splitCallSigns[1], splitDescription);
        }

        public FlightNumber GetFlightNumber()
        {
            return FlightNumber;
        }
        public string GetAreaControllerIdentifier()
        {
            return AreaControllerIdentifier;
        }

        public override bool WithNoDelay()
        {
            throw new NotImplementedException();
        }

        public IClearance FromAirTrafficControllerDescription()
        {
            throw new NotImplementedException();
        }

        public override FlightNumber GetFlightNo()
        {
            return FlightNumber;
        }

        public override string GetAirTrafficControllingTowerIdentifier()
        {
            return this.AreaControllerIdentifier;
        }
    }
}
