using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Arrival;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;

namespace ATC2027.Forms
{
    internal class NonMutableArrivalClearanceFactory
    {
        public static NonMutableArrivalClearance Build(IList<string> SID_Names, IList<STAR> sidList, FlightNumber flightNumber, IAirfield airfield)
        {
            NonMutableArrivalClearance nmac = new NonMutableArrivalClearance(null,null,null,false);
            return nmac;
        }
    }
}