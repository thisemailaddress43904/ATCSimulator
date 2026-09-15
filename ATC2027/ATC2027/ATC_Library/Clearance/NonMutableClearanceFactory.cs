using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.Clearance.DirectControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance
{
    public static class NonMutableClearanceFactory
    {
        public static INonMutableClearance BuildNonMutableControl(ADirectControl mutableClearance)
        {
            return new NonMutableDirectControl(mutableClearance);
        }
            
    }
}
