using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;

namespace ATC2027
{
    public interface IHasArrivalClearance
    {
        public IArrivalClearance? GetArrivalClearance();
    }
}