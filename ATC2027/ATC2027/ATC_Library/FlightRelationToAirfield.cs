using System;

namespace ATC2027.ATC_Library
{
    public static class FlightRelationToAirfield
    {
        public enum FlightRelationToAirfieldEnum
        {
            Departure, Arrival, FlyOver, Unknown
        }

        public static string ToString(FlightRelationToAirfieldEnum flightRelationToAirfield)
        {
            switch (flightRelationToAirfield)
            {
                case FlightRelationToAirfieldEnum.Departure:
                    return "Departure";
                case FlightRelationToAirfieldEnum.Arrival:
                    return "Arrival";
                case FlightRelationToAirfieldEnum.FlyOver:
                    return "FlyOver";
                case FlightRelationToAirfieldEnum.Unknown:
                    return "Unknown";
                default:
                    throw new NotImplementedException($"{flightRelationToAirfield} not yet handled");
            }
        }
    }
}