using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance.WaypointControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance.WaypointControl
{
    public static class NonMutableSTARClearanceFactory
    {
        public static NonMutableSTARClearance Build(IList<string> STAR_Names, IList<STAR> starList, Speed speed, Altitude altitude)
        {
            MutableSTARClearance nmsc = new MutableSTARClearance();

            foreach (string str in STAR_Names)
            {
                bool nmscAlreadyHasSTAR_Present = (nmsc.getStarList().Where(x => x.getName() == str).Count() == 0);

                if (!nmscAlreadyHasSTAR_Present)
                {
                    nmsc.AddSTARByName(starList.First(x => x.getName() == str));
                }
            }
            return new NonMutableSTARClearance(nmsc.Apply(speed).Apply(altitude));
        }
    }
}
