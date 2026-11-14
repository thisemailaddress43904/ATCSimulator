using ATC2027.Controls;
using ATC2027.Database;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATC2027.Clearance.WaypointControl
{
    public class STAR : IComponent, IFromString<STAR>
    {
        string name;
        Vector2 longitudeLatitudeLocation;
        Rectangle drawingRectangle;
        public static Texture2D texture;
        private static int length = 12, height = 12;


        public STAR() { }

        public STAR(string name, Vector2 location)
        {
            this.name = name;
            this.longitudeLatitudeLocation = location;
            this.drawingRectangle = new Rectangle((int)location.X, (int)location.Y, length, height);
        }

        public STAR(string name, float longitude, float latitude)
        {
            this.name = name;
            this.longitudeLatitudeLocation = new Vector2(longitude, latitude);
            this.drawingRectangle = new Rectangle((int)longitudeLatitudeLocation.X, (int)longitudeLatitudeLocation.Y, length, height);
        }

        public STAR(string csvNameLongitudeLatitude)
        {
            string[] strArr = csvNameLongitudeLatitude.Split(',');
            this.name = strArr[0];
            this.longitudeLatitudeLocation = new Vector2(float.Parse(strArr[1]), float.Parse(strArr[2]));
            this.drawingRectangle = new Rectangle((int)longitudeLatitudeLocation.X, (int)longitudeLatitudeLocation.Y, length, height);
        }

        public static class ListFactory
        {
            public static IList<STAR> Build_STAR_List_ForLHR(int setID)
            {
                //using concatenation as data type isn't a string so won't enable sql injection
                string query = $"SELECT CONCAT(tblSTAR.name, ',', tblSTAR.x_coord, ',', tblSTAR.y_coord) as csvNameXY FROM tblSTAR WHERE tblSTAR.setID = " + setID + ";";

                return DatabaseConnectivity.databaseConnectivity.ExecuteInsertionStatement<STAR>(query, "csvNameXY");
            }
        }

        public string getName()
        {
            return name;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, drawingRectangle, Color.CornflowerBlue);
            Text.StaticDraw(spriteBatch, this.name, Constants.getArial_7(), new Vector2(this.drawingRectangle.X, this.drawingRectangle.Y - Constants.getArial_7().MeasureString("!").Y), Color.Black);
        }

        public STAR fromString(string value)
        {
            return new STAR(value);
        }
    }
}
