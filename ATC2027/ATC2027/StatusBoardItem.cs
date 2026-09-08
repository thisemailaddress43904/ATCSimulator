using ATC2027.Library.Altitude;
using ATC2027.Library.Speed;
using ATC2027;
using ATC2027.ATC_Library;
using ATC2027.ATC_Library.Heading;
using static ATC2027.ATC_Library.VerticalMovement;
using static ATC2027.ATC_Library.FlightRelationToAirfield;

namespace ATC2027.Forms
{
    public class StatusBoardItem
    {
        string flightNo;
        string altitudeAsStr;
        string altitudeStatus;
        string headingAsStr;
        string speed;
        string relationToThisAirfield;

        public StatusBoardItem(string flightNo, string altitude, VerticalMovementEnum verticalMovement, IHeading heading, ISpeed speed, FlightRelationToAirfieldEnum flightRelationToAirfield)
        {
            this.flightNo = flightNo;
            this.altitudeAsStr = altitude;
            this.altitudeStatus = VerticalMovement.ToString(verticalMovement);
            this.headingAsStr = heading.ToString();
            this.speed = speed.ToString();
            this.relationToThisAirfield = FlightRelationToAirfield.ToString(flightRelationToAirfield);
        }

        public string getFlightNo() { return flightNo; }
        public string getAltitudeAsStr() { return altitudeAsStr; }
        public string getAltitudeStatus() { return altitudeStatus; }
        public string getHeadingAsStr() {return headingAsStr; }
        public string getSpeed() { return speed; }
        public string getRelationToThisAirfield() { return relationToThisAirfield; }
    }
}
