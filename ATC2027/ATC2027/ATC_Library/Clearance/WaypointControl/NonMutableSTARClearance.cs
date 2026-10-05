using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;

namespace ATC2027.ATC_Library.Clearance.WaypointControl
{
    public class NonMutableSTARClearance : AWaypointClearance, INonMutableClearance
    {
        bool NoDelay;
        IRunway? expectedRunway;
        FlightNumber flightNumber;

        public IList<STAR> starList;
        
        public NonMutableSTARClearance(IList<STAR>? starList = null)
        {
            this.starList = starList;
            this.starList ??= [];
        }

        public override IClearance FromAirTrafficControllerDescription(string description, bool isMutable)
        {
            throw new NotImplementedException();
        }

        public override string GetAirTrafficControllingTowerIdentifier()
        {
            throw new NotImplementedException();
        }

        public override string getDevModeDrawableString()
        {
            throw new NotImplementedException();
        }

        public override IRunway getExpectedRunway()
        {
            return expectedRunway;
        }

        public override FlightNumber GetFlightNo()
        {
            return flightNumber;
        }
        /**
         * Might need to be deleted
         */
        public override void setExpectedRunway(IRunway expectedRunway, IAirfield airfield)
        {
            this.expectedRunway = expectedRunway;
        }

        public override string ToAirTrafficControllerDescription()
        {
            throw new NotImplementedException();
        }

        public override bool WithNoDelay()
        {
            return this.NoDelay;
        }

        
        public void AddSTARByName(STAR star)
        {
            starList.Add(star);
        }

        public Heading getTargetHeading()
        {
            throw new NotImplementedException();
        }

        public Altitude getTargeAltitude()
        {
            throw new NotImplementedException();
        }

        public Speed getTargetSpeed()
        {
            throw new NotImplementedException();
        }
    }
}
