using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Library.FlightNumber;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC2027.ATC_Library.Clearance.WaypointControl
{
    public class NonMutableSIDClearance : AWaypointClearance, INonMutableClearance
    {
        private IList<SID> SIDList;
        private Speed? speed;
        private Altitude? altitude;

        public NonMutableSIDClearance(IList<SID>? sidList, Speed speed, Altitude altitude)
        {
            this.SIDList = sidList;
            this.SIDList ??= [];
            this.speed = speed;
            this.altitude = altitude;
        }

        public class Factory
        {
            public static NonMutableSIDClearance Build(IList<string> items, IList<SID> sids, Speed speed, Altitude altitude)
            {
                return NonMutableSIDClearance(sids.Where(x => items.Contains(x.getName())).ToList(),speed,altitude);
            }

            public static NonMutableSIDClearance NonMutableSIDClearance(List<SID> sids, Speed speed, Altitude altitude)
            {
                NonMutableSIDClearance obj = new NonMutableSIDClearance(sids, speed, altitude);
                return obj;
            }

            public static NonMutableSIDClearance Build(ListBox.ObjectCollection items, IList<SID> sIDs, Speed speed, Altitude altitude)
            {
                IList<String> strings = [];
                foreach(String item in items)
                {
                    strings.Add(item.ToString());
                }

                return Build(strings,sIDs,speed,altitude);
            }
        }

        public override IClearance FromAirTrafficControllerDescription(string description, bool isMutable)
        {
            throw new NotImplementedException();
        }

        public override string GetAirTrafficControllingTowerIdentifier()
        {
            throw new NotImplementedException();
        }

        public override string getDevModeDrawableString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SID_Clearance: ");
            foreach(SID sid in SIDList)
            {
                sb.Append(sid.getName());
                sb.Append(' ');
            }
            sb.Append("- speed - ");
            if (speed == null)
                sb.Append("null - ");
            else
                sb.Append(speed.ToKnots());

            sb.Append("altitude - ");
            if (altitude == null)
                sb.Append("null");
            else
                sb.Append(altitude.ToString());

            return sb.ToString();
        }

        public override IRunway getExpectedRunway()
        {
            throw new NotImplementedException();
        }

        public override FlightNumber GetFlightNo()
        {
            throw new NotImplementedException();
        }

        public Altitude getAltitude()
        {
            return altitude;
        }

        public Heading getHeading()
        {
            return new Heading(0);
        }

        public Speed getSpeed()
        {
            return speed;
        }

        public override string ToAirTrafficControllerDescription()
        {
            throw new NotImplementedException();
        }

        public override bool WithNoDelay()
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
