namespace ATC2027.ATC_Library.CollectionRing
{
    public interface IAircraftCollectionRingItem
    {
        string getFlightNumber();
		string getAltitudeAsString();
		string getSpeedAsString();
		string getHeadingAsString();
		string getRelationToAirfield();
    }
}