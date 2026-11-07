using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Controls.Shape;
using ATC2027.DataStructures;
using ATC2027.Library.FlightNumber;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Plane
{
    public partial class Plane
    {
        public Plane(FlightNumber flNo, IHeading heading, Altitude altitude, ISpeed speed, Vector2 location, GraphicsDevice graphicsDevice, bool hasTakenOff, Color? selectedDrawColor = null, Color? nonSelectedDrawColor = null)
        {
            this.flightNumber = flNo;
            this.heading = new Heading(heading);
            this.altitude = altitude;
            this.speed = speed;


            int sizeOfSquare = 9; //looks better when odd especially when small

            Vector2 topLeftCornerOfSquare = new Vector2(
                location.X -= sizeOfSquare / 2,
                location.Y -= sizeOfSquare / 2);

            this.selectedTextDrawColor = selectedDrawColor == null ? Color.Yellow : (Color)selectedDrawColor;
            this.normalTextDrawColor = nonSelectedDrawColor == null ? Color.White : (Color)nonSelectedDrawColor;

            head = new Square(
                topLeftCornerOfSquare,
                sizeOfSquare,
                Constants.getSpriteBatch().GraphicsDevice);
            tail = new Line(head.GetCentre(), head.GetCentre());

            previousLocations = new MonogameTimeFilteredList<Vector2>(TimeSpan.FromSeconds(3), [head.GetCentre()], TimeSpan.Zero);

            previousLastAppendageToPreviousLocations = lastAppendageToPreviousLocations;
        }
    }
}
