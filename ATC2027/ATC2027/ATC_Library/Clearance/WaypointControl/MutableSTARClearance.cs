using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;

namespace ATC2027.ATC_Library.Clearance.WaypointControl
{
    public class MutableSTARClearance
    {
        private FlightNumber flightNumber;
        private IList<STAR> starList;
        private ISpeed speed;
        private IAltitude altitude;
        private IRunway expectedRunway;


        public IList<STAR> getStarList()
        {
            return starList;
        }

        public MutableSTARClearance()
        {
        }

        public MutableSTARClearance(NonMutableSTARClearance nmsc)
        {
            this.flightNumber = nmsc.GetFlightNo();
            this.starList = nmsc.getStarList();
            this.speed = nmsc.getSpeed();
            this.altitude = nmsc.getAltitude();
        }

        public MutableSTARClearance AddSTARByName(STAR star)
        {
            starList.Add(star);
            return this;
        }

        internal MutableSTARClearance Apply(Speed speed)
        {
            this.speed = speed;
            return this;
        }
        internal MutableSTARClearance Apply(Altitude altitude)
        {
            this.altitude = altitude;
            return this;
        }

        public NonMutableSTARClearance toNonMutableSTAR_Clearance()
        {
            NonMutableSTARClearance nmsc = new NonMutableSTARClearance(flightNumber, expectedRunway, starList, speed, altitude);

            return nmsc;
        }

        internal FlightNumber getFlightNumber()
        {
            return flightNumber;
        }

        internal IRunway getExpectedRunway()
        {
            return expectedRunway;
        }

        internal ISpeed getSpeed()
        {
            return speed;
        }

        internal IAltitude getAltitude()
        {
            return altitude;
        }
    }
}