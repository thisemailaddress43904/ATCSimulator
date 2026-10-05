using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.Interfaces;

namespace ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces
{
    public interface INonMutableDepartureClearance : IDepartureClearance
    {
        public IRunway getRunway();
        public IAirfield getAirfield();
        public bool ClearedToTakeoff();
    }
}