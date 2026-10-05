using ATC2027.ATC_Library.Airfield;
using ATC2027.Interfaces;

namespace ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces
{
    public interface INonMutableArrivalClearance : IHasDevModeDrawableString
    {
        public IRunway getRunway();
        public IAirfield getAirfield();
        public bool ClearedToLand();
    }
}