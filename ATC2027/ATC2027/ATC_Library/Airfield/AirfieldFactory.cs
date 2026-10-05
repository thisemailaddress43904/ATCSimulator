using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.Clearance.WaypointControl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ATC2027.ATC_Library.ControlAttribute.Altitude.AltitudeType;

namespace ATC2027.ATC_Library.Airfield
{
    public static class AirfieldFactory
    {
        public static Airfield BuildLondonHeathrow()
        {
            return new Airfield(
                "London Heathrow", 
                "LHR", 
                new Tuple<float, float>(0, 0),
                Runway.RunwayListFactory.BuildFromListOfHeadings([
                    new Tuple<Heading,IList<string>>(new Heading(270), ["27L","09R"]), 
                    new Tuple<Heading, IList<string>>(new Heading(270), ["27R", "09L"])]),
                new Altitude(0, AltitudeTypeEnum.Feet),
                STAR.ListFactory.Build_STAR_List_ForLHR(),
                SID.ListFactory.Build_SID_List_ForLHR()
                );
        }
    }
}
