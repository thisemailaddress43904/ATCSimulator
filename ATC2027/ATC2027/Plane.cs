using ATC2027.ATC_Library;
using ATC2027.ATC_Library.Clearance;
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
using System.Drawing.Text;

namespace ATC2027
{
    public class Plane : MoveableItem, IHasDevModeDrawableString, IHasClearance
    {
        INonMutableClearance? clearance;
        IDepartureClearance? departureClearance;
        IArrivalClearance? arrivalClearance;
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
        IAltitude altitude;
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
        public Plane(FlightNumber flNo, IHeading heading, IAltitude altitude, ISpeed speed, Vector2 location, GraphicsDevice graphicsDevice, Color? selectedDrawColor = null, Color? nonSelectedDrawColor = null)
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
            UpdateHeadInformation(gameTime);

            tail.Update(gameTime);
            head.Update(gameTime);

            
            UpdateVerticalMovementSymbol();
            previousAltitude = altitude;

            if (isSelected)
            {
                bool leftArrowDown = false;
                bool rightArrowDown = false;

                if (leftArrowDown)
                {
                    this.heading.Decrement();
                    attributesHaveBeenUpdated = true;
                }
                if (rightArrowDown)
                {
                    this.heading.Increment();
                    attributesHaveBeenUpdated = true;
                }
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

        private void UpdateHeadInformation(GameTime gameTime)
        {
            if (head is null)
                return;
            
            float magnitudeOfMovement = (float)gameTime.ElapsedGameTime.Nanoseconds / 500000f * this.speed.ToKnotsFloat();
            Vector2 directionOfMovement = new Vector2(
                (float)Math.Cos(heading.GetHeadingInFloatRadians()),
                (float)Math.Sin(heading.GetHeadingInFloatRadians())
            );
            location = head.GetCentre() + (directionOfMovement * magnitudeOfMovement);
            head.SetCentre(location);
            
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
            return $"tail    start  {tail.GetStartAsString()},  end  {tail.GetStartAsEnd()}\n    previousLocations.Count: {previousLocations.Count}\n    head.getCentre(): {head.GetCentre().ToString()}\n    heading: {heading.ToString()}"; 
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
            this.clearance = clearance;
        }
    }
}
