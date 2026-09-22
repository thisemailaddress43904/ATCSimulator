using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance.AirfieldClearance
{
    public abstract class MutableArrivalClearance : AirportClearance, IMutableClearance, IArrivalClearance
    {
        IAirfield airfield;
        public abstract IRunway GetArrivalRunway();
    }
}
