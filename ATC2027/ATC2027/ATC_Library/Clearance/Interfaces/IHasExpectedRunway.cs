using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance
{
    public interface IHasExpectedRunway
    {
        public IRunway getExpectedRunway();
        /**
         * Throws an error if the expected runway does not exist within the airfield object
         */
        public void setExpectedRunway(IRunway expectedRunway, IAirfield airfield);
    }
}
