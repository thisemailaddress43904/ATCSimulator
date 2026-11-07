using ATC2027.ATC_Library;
using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.CollectionRing;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Controls;
using ATC2027.Controls.Shape;
using ATC2027.DataStructures;
using ATC2027.ExtensionClasses;
using ATC2027.Forms;
using ATC2027.Interfaces;
using ATC2027.Library.FlightNumber;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATC2027.ATC_Library.Plane
{
    public partial class Plane : MoveableItem, IHasDevModeDrawableString, IHasNullableNonMutableClearance, IHasDepartureClearance, IHasArrivalClearance
    {
        #region airfields
        private IAirfield? departureAirfield = AirfieldFactory.BuildLondonHeathrow();
        private IAirfield? arrivalAirfield = AirfieldFactory.BuildLondonHeathrow();
        #endregion

        bool hasTakenOff;
        #region permissable clearances
        public bool CanBeConsideredForLandingClearance => hasTakenOff;
        public bool CanBeConsideredForTakeoffClearance => !hasTakenOff;
        public bool CanBeConsideredForSTARClearance => !hasTakenOff;
        public bool CanBeConsideredForSIDClearance => !hasTakenOff;
        public bool CanBeConsideredForDirectClearance => true;
        #endregion

        #region clearances
        INonMutableClearance? airTimeClearance;
        INonMutableDepartureClearance? departureClearance;
        INonMutableArrivalClearance? arrivalClearance;
        #endregion
        
        bool isApproachingRunwayToLand => arrivalClearance != null;
        bool isReadyToTakeoff => departureClearance != null && (Altitude)altitude > departureAirfield.GetAltitude(); //fails when the arrival airfield is lower than the departure airfield
        bool attributesHaveBeenUpdated;

        Vector2 location;
        
        TimeSpan? timeOfLastUpdate = null;

        bool isSelected = false;

        Color selectedTextDrawColor;
        Color normalTextDrawColor;
        
        #region graphical components
        Square head;
        Line tail;
        #endregion


        TimeSpan lastAppendageToPreviousLocations = TimeSpan.Zero + TimeSpan.FromMicroseconds(1);
        TimeSpan previousLastAppendageToPreviousLocations = TimeSpan.Zero;
        
        MonogameTimeFilteredList<Vector2> previousLocations;
        private static TimeSpan appendToPreviousLocationsFrequency = TimeSpan.FromMilliseconds(100); //the smaller this is the sooner the line drawing updates

        #region textual components
        public string getTopLine() => "fl " + this.altitude.GetAltitudeAsFlightLevel(1) + " " + VerticalMovement.ToString(this.verticalMovement) + " " + this.speed.ToKnots().ToString();
        public string getBottomLine() => flightNumber.ToString();
        #endregion

        //Altitude
        Altitude altitude;
        Altitude previousAltitude;
        VerticalMovement.VerticalMovementEnum verticalMovement;
        bool updateAltitudeNow;
        TimeSpan altitudeUpdateFrequency = TimeSpan.FromMilliseconds(100);
        float rateOfDescentPerPeriod = 15f;
        TimeSpan lastAltitudeUpdate;
        //Speed
        ISpeed speed;
        bool updateSpeedNow;
        TimeSpan lastSpeedUpdate;
        TimeSpan speedUpdateFrequency = TimeSpan.FromMilliseconds(100);
        float speedUpdateRate = 0.5f;
        //FlightNumber
        FlightNumber flightNumber;
        //Heading
        IHeading heading;
        bool updateHeadingNow;
        TimeSpan headingUpdateFrequency = TimeSpan.FromMilliseconds(250);
        TimeSpan lastHeadingUpdate;
        private TimeSpan previousAltitudeWasUpdatedAt;
        #region vertical movement enum and method

        enum FlightRelationToAirfield
        {
            Arrival,Departure,FlyOver,Unknown
        }
        #endregion
        
        bool PlaneIsInAir() {

            bool departureAirfieldIsNull = departureAirfield == null;
            bool arrivalAirfieldIsNull = arrivalAirfield == null;

            if (departureAirfieldIsNull || arrivalAirfieldIsNull)
                throw new Exception($"Plane {flightNoAsStr} has not been properly constructed, its not possible to determine if it is in the air reliably especially at low altitudes. departureAirfield or arrivalAirfield is null");

            bool departureAirfieldAltitudeIsNull = departureAirfield.GetAltitude() == null;
            bool arrivalAirfieldAltitudeIsNull = arrivalAirfield.GetAltitude() == null;

            bool altitudeAttributeIsNull = altitude == null;

            if (departureAirfieldAltitudeIsNull)
                throw new Exception();

            if (arrivalAirfieldAltitudeIsNull)
                throw new Exception();

            if (altitudeAttributeIsNull)
                throw new Exception();

            //its been ensured that no used attributes are null from this point

            return (Altitude)altitude > departureAirfield.GetAltitude() || (Altitude)altitude > arrivalAirfield.GetAltitude();

            
        }
        public float getTurningRadiusFromSpeed()
        {
            return MathExtension.Map(this.speed.ToKnotsFloat()/500f,5,9);
        }

        private void SetVerticalMovementSymbol(GameTime gameTime)
        {        
            UpdatePreviousAltitude(ref previousAltitude, ref altitude, new TimeSpan(0,0,1), this.previousAltitudeWasUpdatedAt, gameTime);
            //var previousAltitudeInFeet = previousAltitude.GetAltitudeInFeet();

            if (previousAltitude == altitude)
                verticalMovement = VerticalMovement.VerticalMovementEnum.constant;
            else if (previousAltitude < altitude)
                verticalMovement = VerticalMovement.VerticalMovementEnum.up;
            else if (previousAltitude > altitude)
                verticalMovement = VerticalMovement.VerticalMovementEnum.down;
            else
                verticalMovement = VerticalMovement.VerticalMovementEnum.unknown;
        }

        private void UpdatePreviousAltitude(ref Altitude previousAltitude, ref Altitude altitude, TimeSpan updateFrequency, TimeSpan? lastUpdateAt, GameTime gt)
        {
            TimeSpan totalGameTime = gt.TotalGameTime;
            
            if (lastUpdateAt == null || totalGameTime > updateFrequency + lastUpdateAt)
                previousAltitude = altitude;

            this.lastAltitudeUpdate = gt.TotalGameTime;
        }

        private void AddPlaneLocationToPreviousLocations(TimeSpan ts)
        {
            previousLocations.AddItem(head.GetCentre(), ts);
        }
        public string getDevModeDrawableString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("tail").Append($"  start  {tail.GetStartAsString()},  end  {tail.GetStartAsEnd()}");
            stringBuilder.AppendLine($"previousLocations.Count: {previousLocations.Count}");
            stringBuilder.AppendLine($"head.getCentre(): {head.GetCentre().ToString()}");
            stringBuilder.AppendLine($"heading: {heading.ToString()}");
            stringBuilder.Append($"airTimeClearance: ").AppendLine(airTimeClearance == null ? "null" : airTimeClearance.getDevModeDrawableString());
            stringBuilder.Append($"departureClearance: ").AppendLine(departureClearance == null ? "null" : departureClearance.getDevModeDrawableString());
            stringBuilder.Append($"arrivalClearance: ").AppendLine(arrivalClearance == null ? "null" : arrivalClearance.getDevModeDrawableString());
            stringBuilder.Append($"arrivalAirfield: ").AppendLine(arrivalAirfield == null ? "null" : arrivalAirfield.getDevModeDrawableString());
            stringBuilder.Append($"departureAirfield: ").AppendLine(departureAirfield == null ? "null" : departureAirfield.getDevModeDrawableString());
            return stringBuilder.ToString();
        }

        public StatusBoardItem toStatusBoardItem()
        {
            return new StatusBoardItem(
                this.flightNoAsStr(), 
                this.altitude.ToString(), 
                this.verticalMovement, 
                this.heading, 
                this.speed, 
                ATC_Library.FlightRelationToAirfield.FlightRelationToAirfieldEnum.FlyOver);
        }
        internal void DecrementHeading()
        {
            this.attributesHaveBeenUpdated = true;
            this.heading.Decrement();
        }

        internal void IncrementHeading()
        {
            this.attributesHaveBeenUpdated = true;
            this.heading.Increment();
        }
    }
}
