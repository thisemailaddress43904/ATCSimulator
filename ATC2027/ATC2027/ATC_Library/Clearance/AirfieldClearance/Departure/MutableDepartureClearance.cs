using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.Clearance;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance.AirfieldClearance.Departure
{
    public class MutableDepartureClearance : AirportClearance, IMutableClearance, IDepartureClearance
    {
        IRunway runway;

        public MutableDepartureClearance(IRunway runway, string airfieldName, FlightNumber flightNumber, bool withNoDelay)
        {
            this.runway = runway;
            this.airfieldName = airfieldName;
            this.flightNumber = flightNumber;
            this.withNoDelay = withNoDelay;
        }

        public MutableDepartureClearance(NonMutableDepartureClearance nmdc)
        {
            this.runway = nmdc.GetRunway();
            this.airfieldName = nmdc.getAirfieldName();
            this.flightNumber = nmdc.GetFlightNo();
            this.withNoDelay = nmdc.WithNoDelay();
        }

        public MutableDepartureClearance ApplyRunway(IRunway runway)
        {
            this.runway = runway;
            return this;
        }

        public MutableDepartureClearance ApplyFlightNumber(FlightNumber flightNumber)
        {
            this.flightNumber = flightNumber;
            return this;
        }

        public MutableDepartureClearance ApplyAirfieldName(string airfieldName)
        {
            this.airfieldName = airfieldName;
            return this;
        }

        public override string getDevModeDrawableString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.airfieldName).Append(" ").Append(base.flightNumber).Append(" cleared to ").Append("take off ").Append(runway.getShorthandName1());

            return sb.ToString();
        }

        public override IClearance FromAirTrafficControllerDescription(string description, bool isMutable)
        {
            throw new NotImplementedException();
        }

        public override string GetAirTrafficControllingTowerIdentifier()
        {
            throw new NotImplementedException();
        }

        public override string ToAirTrafficControllerDescription()
        {
            throw new NotImplementedException();
        }

        public IRunway GetRunway()
        {
            return this.GetRunway();
        }
    }
}
