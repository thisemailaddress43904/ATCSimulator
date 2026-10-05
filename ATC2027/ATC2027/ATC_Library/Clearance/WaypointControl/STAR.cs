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

        public static class ListFactory
        {
            public static IList<STAR> Build_STAR_List_ForLHR()
            {
                return [];
                /*
                STAR w1 = new STAR("w1", new Vector2(,));
                STAR w2 = new STAR("w2", new Vector2(,));
                STAR w3 = new STAR("w3", new Vector2(,));

                STAR wn1 = new STAR("wn1", new Vector2(,));
                STAR wn2 = new STAR("wn2", new Vector2(,));

                STAR ws1 = new STAR("ws1", new Vector2(,));
                STAR ws2 = new STAR("ws2", new Vector2(,));

                STAR e1 = new STAR("e1", new Vector2(,));
                STAR e2 = new STAR("e2", new Vector2(,));
                STAR e3 = new STAR("e3", new Vector2(,));

                STAR en1 = new STAR("en1", new Vector2(,));
                STAR en2 = new STAR("en2", new Vector2(,));

                STAR es1 = new STAR("es1", new Vector2(,));
                STAR es2 = new STAR("es2", new Vector2(,));

                return [w1, w2, w3, wn1, wn2, ws1, ws2, e1, e2, e3, en1, en2, es1, es2];
                */
            }
        }

        public string getName()
        {
            return name;
        }
    }
}
