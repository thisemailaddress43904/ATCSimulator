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
    public class Clearance : IClearance
    {
        private IHeading Heading;
        IAltitude altitude;
        ISpeed speed;

        public Clearance(IHeading heading = null, IAltitude altitude = null, ISpeed speed = null)
        {
            this.Heading = heading;
            this.altitude = altitude;
            this.speed = speed;
        }

        public IClearance ApplyHeading(IHeading heading)
        {
            this.Heading = heading;
            return this;
        }

        public IClearance ApplyAltitude(IAltitude altitude)
        {
            this.altitude = altitude;
            return this;
        }

        public IClearance ApplySpeed(ISpeed speed)
        {
            this.speed = speed;
            return this;
        }
        public void Empty()
        {
            this.speed = null;
            this.altitude = null;
            this.Heading = null;
        }

        public static Clearance getEmptyClearance()
        {
            return new Clearance(null, null, null);
        }

        public IHeading GetHeading()
        {
            return Heading;
        }

        public ISpeed GetSpeed()
        {
            return speed;
        }

        public IAltitude GetAltitude()
        {
            return altitude;
        }
    }
}
