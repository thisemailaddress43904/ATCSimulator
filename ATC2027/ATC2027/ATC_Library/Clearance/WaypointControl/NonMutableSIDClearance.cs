using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.Clearance;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance.WaypointControl
{
    public class NonMutableSIDClearance : AWaypointClearance, INonMutableClearance
    {
        private IList<SID> SIDList;

        public NonMutableSIDClearance(IList<SID>? sidList)
        {
            this.SIDList = sidList;
            this.SIDList ??= [];
        }

        public override IClearance FromAirTrafficControllerDescription(string description, bool isMutable)
        {
            throw new NotImplementedException();
        }

        public override string GetAirTrafficControllingTowerIdentifier()
        {
            throw new NotImplementedException();
        }

        public override IRunway getExpectedRunway()
        {
            throw new NotImplementedException();
        }

        public override FlightNumber GetFlightNo()
        {
            throw new NotImplementedException();
        }

        public override void setExpectedRunway(IRunway expectedRunway, IAirfield airfield)
        {
            throw new NotImplementedException();
        }

        public override string ToAirTrafficControllerDescription()
        {
            throw new NotImplementedException();
        }

        public override bool WithNoDelay()
        {
            throw new NotImplementedException();
        }
    }
}
