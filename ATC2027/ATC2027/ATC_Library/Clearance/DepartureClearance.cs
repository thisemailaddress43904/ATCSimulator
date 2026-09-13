using ATC2027.Clearance;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance
{
    public class DepartureClearance : AirportClearance
    {
        IClearance clearedTo;
        public IClearance FromAirTrafficControllerDescription(string description, bool isMutable)
        {
            throw new NotImplementedException();
        }

        public string GetAirTrafficControllingTowerIdentifier()
        {
            throw new NotImplementedException();
        }

        public FlightNumber GetFlightNo()
        {
            throw new NotImplementedException();
        }

        public string ToAirTrafficControllerDescription()
        {
            throw new NotImplementedException();
        }

        public bool WithNoDelay()
        {
            throw new NotImplementedException();
        }
    }
}
