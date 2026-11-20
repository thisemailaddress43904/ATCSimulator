using ATC2027.ATC_Library.ControlAttribute.Heading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ATC2027.ATC_Library.Airfield
{
    public class TarmacStrip : ITarmacStrip
    {
        ISet<Runway> runwayCollection;
        Texture2D texture;
        Rectangle rectangle;
        float rectangleAngle;
        Vector2 origin;

        public TarmacStrip(IList<Tuple<string, IHeading, Vector2, Vector2>> tupleNameOfRunwayHeadingSpawnPointAndTextLocation, Texture2D texture, Rectangle destinationRectangle)
        {
            this.runwayCollection = new HashSet<Runway>();

            foreach (Tuple<string, IHeading, Vector2, Vector2> tuple in tupleNameOfRunwayHeadingSpawnPointAndTextLocation) {
                this.runwayCollection.Add(new Runway(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4));
            }
            this.texture = texture;
            rectangle = destinationRectangle;
        }

        public static Texture2D Texture { get; internal set; }

        public bool Contains2Runways()
        {
            return runwayCollection.Count == 2;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, null, Color.White, rectangleAngle, origin, SpriteEffects.None, 1);
            foreach (var runway in runwayCollection)
            {
                runway.Draw(gameTime, spriteBatch);
            }
        }

        public IRunway getRunwayByName(string name)
        {
            IList<IRunway> values = this.getRunways().Where(x => x.getShorthandName() == name).ToList();

            if (values.Count == 0)
                return null;

            return values.First();    
        }

        public IEnumerable<IRunway> getRunways()
        {
            return this.runwayCollection;
        }

        public void Update(GameTime gameTime)
        {
            
        }
    }
}
