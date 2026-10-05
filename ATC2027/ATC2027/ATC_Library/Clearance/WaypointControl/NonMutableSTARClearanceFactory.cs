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
        public static NonMutableSTARClearance Build(IList<string> STAR_Names, IList<STAR> starList)
        {
            NonMutableSTARClearance nmsc = new NonMutableSTARClearance();

            foreach (string str in STAR_Names)
            {
                bool nmscAlreadyHasSTAR_Present = (nmsc.starList.Where(x => x.getName() == str).Count() == 0);

                if (!nmscAlreadyHasSTAR_Present)
                {
                    nmsc.AddSTARByName(starList.Where(x => x.getName() == str).First());
                }
                else
                {
                    
                }
            }
           return nmsc;

        }
    }
}
