using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;

namespace ATC2027.ATC_Library.Plane
{
    public interface IHasArrivalClearance
    {
        public IArrivalClearance? GetArrivalClearance();
    }
}