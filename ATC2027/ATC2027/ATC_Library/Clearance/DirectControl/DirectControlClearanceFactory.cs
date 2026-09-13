using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Clearance.DirectControl;
using ATC2027.Library.FlightNumber;
using System.Text.RegularExpressions;

namespace ATC2027.ATC_Library.Clearance.DirectControl
{
    public class DirectControlClearanceFactory
    {
        public static DirectControl2 BuildDirectControlClearance(bool isMutable, FlightNumber FlightNumber, string AreaIdentifier, string[] controlAttributesArray)
        {

            IAltitude? DetermineAltitude(ref string[] controlAttributes)
            {
                string regexPattern = "%d{1:3}";
                string nameOfAttribute = "altitude";
                Regex regex = new Regex(regexPattern);

                return null;
            }
            IHeading? DetermineHeading(ref string[] controlAttributes)
            {
                string regexPattern = "%d{1:2}";

                string nameOfAttribute = "heading";
                Regex regex = new Regex(regexPattern);

                return null;
            }
            ISpeed? DetermineSpeed(ref string[] controlAttributes)
            {
                string regexPattern = "%d%d%d";
                string nameOfAttribute = "heading";
                Regex regex = new Regex(regexPattern);

                return null;
            }
            
            

            IAltitude altitude = DetermineAltitude(ref controlAttributesArray);
            IHeading heading = DetermineHeading(ref controlAttributesArray);
            ISpeed speed = DetermineSpeed(ref controlAttributesArray);

            return BuildDirectControlClearance(isMutable, FlightNumber, AreaIdentifier, altitude, heading, speed, null);
            
        }
        public static DirectControl2 BuildDirectControlClearance(bool isMutable, FlightNumber FlightNumber, string AreaIdentifier, IAltitude altitude, IHeading heading, ISpeed speed, IRunway expectedRunway)
        {
            if (isMutable)
                return new MutableDirectControl(FlightNumber, AreaIdentifier, altitude, heading, speed, expectedRunway);

            return new NonMutableDirectControl(FlightNumber, AreaIdentifier, altitude, heading, speed, expectedRunway);
        }
    }
}
