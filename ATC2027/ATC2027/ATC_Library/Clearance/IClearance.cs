using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Clearance
{
    public interface IClearance
    {
        public bool WithNoDelay();
        public string ToAirTrafficControllerDescription();
        public IClearance FromAirTrafficControllerDescription(string description, bool isMutable);

        public FlightNumber GetFlightNo();
        public string GetAirTrafficControllingTowerIdentifier();
    }
}
