using ATC2027.Controls;
using ATC2027.Database;
using ATC2027.Interfaces;
using Microsoft.Data.Sqlite;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace ATC2027.Clearance.WaypointControl
{
    public class SID : IComponent, IFromString<SID>
    {
        string name;
        Vector2 longitudeLatitudeLocation;
        public static Texture2D texture;
        private Rectangle drawingRectangle;

        public int length = 6, width = 6;

        public SID() { }

        public SID(string name, Vector2 location)
        {
            this.name = name;
            this.longitudeLatitudeLocation = location;
            this.drawingRectangle = new Rectangle((int)location.X, (int)location.Y, width, length);
        }

        public SID(string name, float longitude, float latitude)
        {
            this.name = name;
            this.longitudeLatitudeLocation = new Vector2(longitude, latitude);
            this.drawingRectangle = new Rectangle((int)longitude, (int)latitude, width, length);
        }

        public SID(string csvNameLongitudeLatitude)
        {
            string[] strArr = csvNameLongitudeLatitude.Split(',');
            this.name = strArr[0];
            this.longitudeLatitudeLocation = new Vector2(float.Parse(strArr[1]), float.Parse(strArr[2]));
            this.drawingRectangle = new Rectangle((int)longitudeLatitudeLocation.X, (int)longitudeLatitudeLocation.Y, length, width);
        }
              
        public static class Factory {
            public static IList<SID> Build_SID_List_ForLHR(int setID)
            {
                //using concatenation as data type isn't a string so won't enable sql injection
                string query = $"SELECT CONCAT(tblSID.name, ',', tblSID.x_coord, ',', tblSID.y_coord) as csvNameXY FROM tblSID WHERE tblSID.setID = " + setID + ";";

                return DatabaseConnectivity.databaseConnectivity.ExecuteInsertionStatement<SID>(query, "csvNameXY");
            }
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, drawingRectangle, Color.CornflowerBlue);
            Text.StaticDraw(spriteBatch, this.name, Constants.getArial_7(), new Vector2(this.drawingRectangle.X, this.drawingRectangle.Y - Constants.getArial_7().MeasureString("!").Y), Color.Black);
        }
        public Vector2 GetLongitudeAndLattitude()
        {
            return this.longitudeLatitudeLocation;
        }
        public SID fromString(string value)
        {
            return new SID(value);
        }
    }
}
    
