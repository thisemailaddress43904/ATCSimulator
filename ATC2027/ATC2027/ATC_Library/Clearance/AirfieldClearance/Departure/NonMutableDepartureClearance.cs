using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance.AirfieldClearance.Departure
{
    public class NonMutableDepartureClearance : AirportClearance, INonMutableClearance, INonMutableDepartureClearance
    {
        IRunway runway;

        public NonMutableDepartureClearance(IRunway runway, string airfieldName, FlightNumber flightNumber, bool withNoDelay)
        {
            this.runway = runway;
            this.airfieldName = airfieldName;
            this.flightNumber = flightNumber;
            this.withNoDelay = withNoDelay;
        }

        public NonMutableDepartureClearance(MutableDepartureClearance nmdc)
        {
            this.runway = nmdc.GetRunway();
            this.airfieldName = nmdc.getAirfieldName();
            this.flightNumber = nmdc.GetFlightNo();
            this.withNoDelay = nmdc.WithNoDelay();
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
        public FlightNumber GetFlightNo()
        {
            return this.flightNumber;
        }
        public override string ToAirTrafficControllerDescription()
        {
            throw new NotImplementedException();
        }
        public bool WithNoDelay()
        {
            return this.withNoDelay;
        }
        public IRunway GetRunway()
        {
            return this.runway;
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

        public IRunway getRunway()
        {
            throw new NotImplementedException();
        }

        public IAirfield getAirfield()
        {
            throw new NotImplementedException();
        }

        public bool ClearedToTakeoff()
        {
            throw new NotImplementedException();
        }
    }
}
