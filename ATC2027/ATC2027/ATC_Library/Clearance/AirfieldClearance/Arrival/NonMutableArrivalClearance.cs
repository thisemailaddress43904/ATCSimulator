using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Library.FlightNumber;
using System;

namespace ATC2027.ATC_Library.Clearance.AirfieldClearance.Arrival
{
    public class NonMutableArrivalClearance : AirportClearance, INonMutableClearance, IArrivalClearance, INonMutableArrivalClearance
    {
        public NonMutableArrivalClearance(IRunway runway, IAirfield airfield, FlightNumber flNo, bool withNoDelay)
        {
            base.airfieldName = airfieldName;
            base.withNoDelay = withNoDelay;
            base.flightNumber = flNo;
            base.runway = runway;
        }
        
        INonMutableClearance nonMutableClearance;
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
            throw new NotImplementedException();
        }

        public override string ToAirTrafficControllerDescription()
        {
            throw new NotImplementedException();
        }

        public bool WithNoDelay()
        {
            throw new NotImplementedException();
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

        public bool ClearedToLand()
        {
            throw new NotImplementedException();
        }
    }
}
