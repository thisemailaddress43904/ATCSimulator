using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Clearance.WaypointControl
{
    public class STAR
    {
        string name;
        Vector2 longitudeLatitudeLocation;
        public STAR(string name, Vector2 location)
        {
            this.name = name;
            this.longitudeLatitudeLocation = location;
        }
    }
}
