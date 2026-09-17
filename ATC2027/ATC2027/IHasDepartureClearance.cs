using ATC2027.ATC_Library.Clearance.Interfaces;

namespace ATC2027
{
    public interface IHasDepartureClearance
    {
        public IDepartureClearance? GetDepartureClearance();
    }
}