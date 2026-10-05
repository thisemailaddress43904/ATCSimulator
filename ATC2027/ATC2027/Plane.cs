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

namespace ATC2027
{
    public class Plane : MoveableItem, IHasDevModeDrawableString, IHasNullableNonMutableClearance, IHasDepartureClearance, IHasArrivalClearance
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
        IAltitude previousAltitude;
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
        #region vertical movement enum and method

        enum FlightRelationToAirfield
        {
            Arrival,Departure,FlyOver,Unknown
        }
        #endregion
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

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            head.Draw(gameTime, spriteBatch);
            tail.Draw(gameTime, spriteBatch);
            
            DrawTopLine(spriteBatch, ref head);
            DrawBottomLine(spriteBatch, ref head);
        }

        private void DrawBottomLine(SpriteBatch spriteBatch, ref Square planeHead)
        {
            var font = Constants.getArial_7();
            var location = planeHead.GetCentre();
            var str = getBottomLine();
            location.X -= font.MeasureString(str).X / 2;
            location.Y += font.MeasureString(str).Y / 2;

            if (isSelected)
            {
                Text.StaticDraw(spriteBatch, str, font, location, selectedTextDrawColor);
            }
            else
            {
                Text.StaticDraw(spriteBatch, str, font, location, normalTextDrawColor);
            }
            
        }

        private void DrawTopLine(SpriteBatch spriteBatch, ref Square planeHead)
        {
            var font = Constants.getArial_7();
            var location = planeHead.GetCentre();
            var topLine = getTopLine();

            var str = StringExtension.characterReplacer(topLine + topLine, ' ');


            location.X -= font.MeasureString(str).X / 2;
            location.Y -= font.MeasureString(str).Y;
            
            if (isSelected)
                Text.StaticDraw(spriteBatch, topLine, font, location, selectedTextDrawColor);
            else
                Text.StaticDraw(spriteBatch, topLine, font, location, normalTextDrawColor);
        }

        private void UpdateHeading()
        {
            if (airTimeClearance == null)
                return;

            if (airTimeClearance.getTargetHeading() == null)
                return;
            float clearanceHeading = airTimeClearance.getTargetHeading().GetHeadingInFloatDegrees();
            float actualHeading = this.heading.GetHeadingInFloatDegrees();

            bool clearanceHeadingAndHeadingAreDifferent = clearanceHeading == actualHeading;
            //update heading
            if (!clearanceHeadingAndHeadingAreDifferent)
            {
                if (Math.Abs(clearanceHeading - actualHeading) < 1)
                    heading = airTimeClearance.getTargetHeading();
                else if (clearanceHeading < actualHeading)
                    heading = heading.Decrement(getTurningRadiusFromSpeed());
                else
                    heading = heading.Increment(getTurningRadiusFromSpeed());

                this.attributesHaveBeenUpdated = true;
            }
        }

        public override void Update(GameTime gameTime)
        {
            //Determine draw colour of the head and tail
            if (isSelected)
            {
                head.SetColor(selectedTextDrawColor);
                tail.SetColor(selectedTextDrawColor);
            }
            else
            {
                head.SetColor(normalTextDrawColor);
                tail.SetColor(normalTextDrawColor);
            }
            

            UpdateTailInformation(gameTime);
            UpdateHeadInformation(gameTime, airTimeClearance, departureClearance, arrivalClearance);

            tail.Update(gameTime);
            head.Update(gameTime);

            #region updateHeading
            updateHeadingNow = lastHeadingUpdate + headingUpdateFrequency < gameTime.TotalGameTime;
            if (updateHeadingNow)
            {
                UpdateHeading();
                lastHeadingUpdate = gameTime.TotalGameTime;
                updateHeadingNow = false;
            }
            #endregion
            #region updateAltitude
            updateAltitudeNow = lastAltitudeUpdate + altitudeUpdateFrequency < gameTime.TotalGameTime;
            if (updateAltitudeNow)
            {
                UpdateAltitude();
                lastAltitudeUpdate = gameTime.TotalGameTime;
                updateAltitudeNow = false;
            }
            #endregion
            #region updateSpeed
            updateSpeedNow = lastSpeedUpdate + speedUpdateFrequency < gameTime.TotalGameTime;
            if (updateSpeedNow)
            {
                UpdateSpeed();
                lastSpeedUpdate = gameTime.TotalGameTime;
                updateSpeedNow = false;
            }
            #endregion

            UpdateVerticalMovementSymbol();
            previousAltitude = altitude;
        }

        private void UpdateSpeed()
        {
            if (airTimeClearance == null)
                return;
            if (airTimeClearance.getTargetSpeed() == null)
                return;

            float clearanceSpeed = airTimeClearance.getTargetSpeed().ToKnotsFloat();
            float actualSpeed = this.speed.ToKnotsFloat();

            bool clearanceSpeedAndActualSpeedAreDifferent = clearanceSpeed == actualSpeed;

            if (!clearanceSpeedAndActualSpeedAreDifferent)
            {
                if (Math.Abs(clearanceSpeed - actualSpeed) < speedUpdateRate + 0.1)
                    speed = airTimeClearance.getTargetSpeed();
                else if (clearanceSpeed < actualSpeed)
                    speed = speed.Decrement(speedUpdateRate);
                else
                    speed = speed.Increment(speedUpdateRate);

                this.attributesHaveBeenUpdated = true;
            }
        }
        private void UpdateAltitude()
        {
            if (airTimeClearance == null)
                return;

            if (airTimeClearance.getTargeAltitude() == null)
                return;

            float clearanceAltitude = airTimeClearance.getTargeAltitude().GetAltitudeInFeet();
            float actualAltitude = this.altitude.GetAltitudeInFeet();

            bool clearanceAltitudeAndRealAltitudeAreDifferent = clearanceAltitude == actualAltitude;
            //update heading
            if (!clearanceAltitudeAndRealAltitudeAreDifferent)
            {
                if (Math.Abs(clearanceAltitude - actualAltitude) < 1)
                    altitude = airTimeClearance.getTargeAltitude();
                else if (clearanceAltitude < actualAltitude)
                    altitude = altitude.Decrement(rateOfDescentPerPeriod);
                else
                    altitude = altitude.Increment(rateOfDescentPerPeriod);

                this.attributesHaveBeenUpdated = true;
            }
        }
        private void UpdateVerticalMovementSymbol()
        {
            if (previousAltitude == null || altitude == null)
            {
                verticalMovement = VerticalMovement.VerticalMovementEnum.unknown;
                return;
            }
            var previousAltitudeInFeet = previousAltitude.GetAltitudeInFeet();
            var currentAltitudeInFeet = altitude.GetAltitudeInFeet();
            if (previousAltitudeInFeet == currentAltitudeInFeet)
                verticalMovement = VerticalMovement.VerticalMovementEnum.constant;
            else if (previousAltitudeInFeet < currentAltitudeInFeet)
                verticalMovement = VerticalMovement.VerticalMovementEnum.up;
            else if (previousAltitudeInFeet > currentAltitudeInFeet)
                verticalMovement = VerticalMovement.VerticalMovementEnum.down;
            else
                verticalMovement = VerticalMovement.VerticalMovementEnum.unknown;
        }

        

        public bool getAttributesHaveBeenUpdated()
        {
            return this.attributesHaveBeenUpdated;
        }

        public void setAttributesHaveBeenUpdated(bool changeInAttributesHasBeenHandled)
        {
            this.attributesHaveBeenUpdated = changeInAttributesHasBeenHandled;
        }

        private void UpdateHeadInformation(GameTime gameTime, INonMutableClearance airTimeClearance, INonMutableDepartureClearance departureClearance, INonMutableArrivalClearance arrivalClearance)
        {
            if (head is null)
                return;
            
            float magnitudeOfMovement = (float)gameTime.ElapsedGameTime.Nanoseconds / 750000f * this.speed.ToKnotsFloat();
            Vector2 directionOfMovement = new Vector2(
                (float)Math.Cos(heading.GetHeadingInFloatRadians()),
                (float)Math.Sin(heading.GetHeadingInFloatRadians())
            );
            location = head.GetCentre() + (directionOfMovement * magnitudeOfMovement);
            head.SetCentre(location);
            

            

            if (PlaneIsInAir())
            //aircraft has landed or is getting ready to depart - crash landings have been implemented
            {
                if (isApproachingRunwayToLand)
                //aircraft is getting ready to land
                {
                    //altitude, speed and heading should be modified towards the entry point for the runway
                }
                else
                {
                    //check for STAR, SID or DirectControl clearance
                }
            }
            else
            {
                if (isReadyToTakeoff)
                //Airplane is ready to takeoff
                {

                }
                else
                //Airplane has already taken of
                {

                }
            }
        }

        private void UpdateTailInformation(GameTime gameTime)
        {
            previousLocations.UpdateDataStructure(gameTime.TotalGameTime);
            //update start and end point of the tail only when there's been an update to previous locations
            if (previousLastAppendageToPreviousLocations != lastAppendageToPreviousLocations)
            {
                try
                {
                    tail.SetStart(previousLocations.Last());
                }
                catch (ArgumentNullException)
                {
                    tail.SetStart(null);
                }
                try
                {
                    tail.SetEnd(previousLocations.First());
                }
                catch (ArgumentException)
                {
                    tail.SetEnd(null);
                }

                previousLastAppendageToPreviousLocations = lastAppendageToPreviousLocations;
            }

            //see if item should be added
            TimeSpan ts = gameTime.TotalGameTime;
            if (lastAppendageToPreviousLocations + appendToPreviousLocationsFrequency < ts)
            {
                AddPlaneLocationToPreviousLocations(ts);
                lastAppendageToPreviousLocations = ts;
            }
        }

        private float CalculateHeadingBasedXMultiplier(float heading)
        {
            heading = heading % 360;
            float toReturn = 0;

            if (heading <= 90)
                toReturn = MathExtension.Map(heading / 360, 0, 1);
            else if (heading <= 270)
                toReturn = MathExtension.Map(heading / 360, -1, 1);
            else if (heading <= 360)
                toReturn = MathExtension.Map(heading / 360, -1, 0);
            return toReturn;

        }
        private float CalculateHeadingBasedYMultiplier(float heading)
        {
            heading = heading % 360;
            float toReturn = 0;

            if (heading <= 180)
                toReturn = MathExtension.Map(heading / 360, -1, 1);
            else if (heading <= 360)
                toReturn = MathExtension.Map(heading / 360, 1, -1);
            
            return toReturn;
        }
        private void AddPlaneLocationToPreviousLocations(TimeSpan ts)
        {
            previousLocations.AddItem(head.GetCentre(), ts);
        }
        
        string altitudeAsStr()
        {
           return altitude.ToString();
        }
        
        string speedAsStr()
        {
            return speed.ToKnots().ToString();
        }
        
        public string flightNoAsStr()
        {
            return flightNumber.ToString();
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

        internal IAircraftCollectionRingItem ToAirCraftCollectionRingItem()
        {
            throw new NotImplementedException();
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

        public Vector2 getLocation()
        {
            return location;
        }

        internal void SetIsSelected(bool value)
        {
            this.isSelected = value;
        }

        public Dictionary<string, string> clearanceAttributesAsDictionary()
        {
            throw new NotImplementedException();
        }

        internal void setClearance(ref INonMutableClearance clearance)
        {
            this.airTimeClearance = clearance;
        }

        public INonMutableClearance? GetClearance()
        {
            return this.airTimeClearance;
        }

        public IDepartureClearance? GetDepartureClearance()
        {
            return this.departureClearance;
        }

        public INonMutableArrivalClearance? GetArrivalClearance()
        {
            return this.arrivalClearance;
        }

        internal void SetDepartureClearance(INonMutableDepartureClearance clearance)
        {
            this.departureClearance = clearance;
        }

        internal void SetArrivalClearance(INonMutableArrivalClearance clearance)
        {
            this.arrivalClearance = clearance;
        }

        IArrivalClearance IHasArrivalClearance.GetArrivalClearance()
        {
            throw new NotImplementedException();
        }
    }
}
