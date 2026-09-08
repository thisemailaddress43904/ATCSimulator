using ATC2027.ATC_Library.Heading;
using ATC2027.Library.Altitude;
using ATC2027.Library.Speed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Clearance
{
    public interface IClearance
    {
        /// <summary>
        /// Updates the altitude variable within the data structure
        /// </summary>
        /// <param name="altitude"></param>
        /// <returns></returns>
        IClearance ApplyAltitude(IAltitude altitude);
        /// <summary>
        ///  Updates the heading variable within the data structure
        /// </summary>
        /// <param name="heading"></param>
        /// <returns></returns>
        IClearance ApplyHeading(IHeading heading);
        /// <summary>
        ///  Updates the speed variable within the data structure
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        IClearance ApplySpeed(ISpeed speed);
        /// <summary>
        /// Emptys the object of all clearances
        /// </summary>
        void Empty();
        IHeading GetHeading();
        ISpeed GetSpeed();
        IAltitude GetAltitude();
    }
}
