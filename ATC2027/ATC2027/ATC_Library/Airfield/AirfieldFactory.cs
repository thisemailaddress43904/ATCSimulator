using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.Clearance.WaypointControl;
using Microsoft.Xna.Framework;
using System;
using static ATC2027.ATC_Library.ControlAttribute.Altitude.AltitudeType;

namespace ATC2027.ATC_Library.Airfield
{
    public static class AirfieldFactory
    {
        public static Airfield BuildLondonHeathrow()
        {
            return new Airfield(
                "London Heathrow", 
                "LHR", 
                new Tuple<float, float>(0, 0),
                [
                    new TarmacStrip([
                        new Tuple<string, IHeading, Vector2, Vector2>(
                            "09L", 
                            new Heading(90),
                            new Vector2(Constants.getMiddleOfScreenWidth - TarmacStrip.Texture.Width / 2,Constants.getMiddleOfScreenHeight - TarmacStrip.Texture.Height + 4), 
                            new Vector2(Constants.getMiddleOfScreenWidth - TarmacStrip.Texture.Width, (float)(Constants.getMiddleOfScreenHeight - TarmacStrip.Texture.Height))),
                        new Tuple<string, IHeading, Vector2, Vector2>(
                            "27R",
                            new Heading(270),
                            new Vector2(Constants.getMiddleOfScreenWidth + TarmacStrip.Texture.Width / 2 - 5,Constants.getMiddleOfScreenHeight - TarmacStrip.Texture.Height + 4), 
                            new Vector2(Constants.getMiddleOfScreenWidth + TarmacStrip.Texture.Width / 2 + 8, (float)(Constants.getMiddleOfScreenHeight - TarmacStrip.Texture.Height)))
                    ], TarmacStrip.Texture, new Rectangle(Constants.getMiddleOfScreenWidth - TarmacStrip.Texture.Width / 2, Constants.getMiddleOfScreenHeight - TarmacStrip.Texture.Height / 2, TarmacStrip.Texture.Width, TarmacStrip.Texture.Height)),
                    new TarmacStrip([
                        new Tuple<string, IHeading, Vector2, Vector2>(
                            "09R", 
                            new Heading(90),
                            new Vector2(Constants.getMiddleOfScreenWidth - TarmacStrip.Texture.Width / 2,Constants.getMiddleOfScreenHeight + TarmacStrip.Texture.Height + 2), 
                            new Vector2(Constants.getMiddleOfScreenWidth - TarmacStrip.Texture.Width, (float)(Constants.getMiddleOfScreenHeight + TarmacStrip.Texture.Height))),
                        new Tuple<string, IHeading, Vector2, Vector2>(
                            "27L", 
                            new Heading(270),
                            new Vector2(Constants.getMiddleOfScreenWidth + TarmacStrip.Texture.Width / 2 - 5, Constants.getMiddleOfScreenHeight + TarmacStrip.Texture.Height + 2), 
                            new Vector2(Constants.getMiddleOfScreenWidth + TarmacStrip.Texture.Width / 2 + 8, (float)(Constants.getMiddleOfScreenHeight + TarmacStrip.Texture.Height)))
                    ], TarmacStrip.Texture, new Rectangle(Constants.getMiddleOfScreenWidth - TarmacStrip.Texture.Width / 2, (int)(Constants.getMiddleOfScreenHeight + (TarmacStrip.Texture.Height / 2 * 2.5f)), TarmacStrip.Texture.Width, TarmacStrip.Texture.Height))
                ],
                new Altitude(0, AltitudeTypeEnum.Feet),
                STAR.ListFactory.Build_STAR_List_ForLHR(0),
                SID.Factory.Build_SID_List_ForLHR(0)
                );
        }
    }
}
