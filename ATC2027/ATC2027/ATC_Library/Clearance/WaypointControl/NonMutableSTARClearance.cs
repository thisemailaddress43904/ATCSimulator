using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Library.FlightNumber;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace ATC2027.ATC_Library.Clearance.WaypointControl
{
    public class NonMutableSTARClearance : AWaypointClearance, INonMutableClearance
    {
        private readonly bool NoDelay;
        private readonly IRunway? expectedRunway;
        private readonly FlightNumber flightNumber;
        private readonly IList<STAR> starList;
        private readonly Speed speed;
        private readonly Altitude altitude;


        public NonMutableSTARClearance(FlightNumber flightNumber, IRunway expectedRunway = null, IList<STAR>? starList = null, ISpeed speed = null, IAltitude altitude = null)
        {
            this.flightNumber = flightNumber;
            this.expectedRunway = expectedRunway;
            this.starList = starList;
            this.starList ??= [];
            this.speed = (Speed)speed;
            this.altitude = (Altitude)altitude;
        }

        public NonMutableSTARClearance(MutableSTARClearance msc)
        {
            this.flightNumber = msc.getFlightNumber();
            this.expectedRunway = msc.getExpectedRunway();
            this.starList = msc.getStarList();
            this.speed = (Speed)msc.getSpeed();
            this.altitude = (Altitude)msc.getAltitude();
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

        public Altitude getAltitude()
        {
            return altitude;
        }

        public Speed getSpeed()
        {
            return speed;
        }

        internal IList<STAR> getStarList()
        {
            return starList;
        }

        public Heading getHeading()
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
