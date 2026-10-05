using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.Clearance.WaypointControl
{
    public class SID : IComponent
    {
        string name;
        Vector2 longitudeLatitudeLocation;
        static Texture2D texture;
        public SID(string name, Vector2 location)
        {
            this.name = name;
            this.longitudeLatitudeLocation = location;
        }

        public static class ListFactory
        {
            public static IList<SID> Build_SID_List_ForLHR()
            {
                return [];
                /*
                SID w1 = new SID("w1", new Vector2(,));
                SID w2 = new SID("w2", new Vector2(,));
                SID w3 = new SID("w3", new Vector2(,));

                SID wn1 = new SID("wn1", new Vector2(,));
                SID wn2 = new SID("wn2", new Vector2(,));

                SID ws1 = new SID("ws1", new Vector2(,));
                SID ws2 = new SID("ws2", new Vector2(,));

                SID e1 = new SID("e1", new Vector2(,));
                SID e2 = new SID("e2", new Vector2(,));
                SID e3 = new SID("e3", new Vector2(,));

                SID en1 = new SID("n1", new Vector2(,));
                SID en2 = new SID("en2", new Vector2(,));

                SID es1 = new SID("es1", new Vector2(,));
                SID es2 = new SID("es2", new Vector2(,));

                return [w1, w2, w3, wn1, wn2, ws1, ws2, e1, e2, e3, en1, en2, es1, es2];
                */
            }
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
        public Vector2 GetLongitudeAndLattitude()
        {
            return this.longitudeLatitudeLocation;
        }
    }
}
    
