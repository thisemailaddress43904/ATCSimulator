using ATC2027.ATC_Library.Airfield;
using ATC2027.Clearance;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance
{
    public abstract class AirportClearance : IClearance
    {
        protected string airfieldName;
        protected FlightNumber flightNumber;
        protected bool withNoDelay = false;
        protected IRunway runway;
        public abstract IClearance FromAirTrafficControllerDescription(string description, bool isMutable);

        public abstract string GetAirTrafficControllingTowerIdentifier();

        public abstract string getDevModeDrawableString();
        public abstract string ToAirTrafficControllerDescription();
        public virtual string getAirfieldName()
        {
            return airfieldName;
        }
        public virtual FlightNumber GetFlightNo()
        {
            return this.GetFlightNo();
        }
        public virtual bool WithNoDelay()
        {
            return this.withNoDelay;
        }
    }
}
