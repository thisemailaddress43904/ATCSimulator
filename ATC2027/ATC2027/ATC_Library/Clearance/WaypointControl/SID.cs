using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Clearance.WaypointControl
{
    public class SID
    {
        string name;
        Vector2 longitudeLatitudeLocation;
        public SID(string name, Vector2 location)
        {
            this.name = name;
            this.longitudeLatitudeLocation = location;
        }
    }
}
