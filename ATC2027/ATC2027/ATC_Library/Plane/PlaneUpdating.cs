using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;
using ATC2027.ATC_Library.Clearance.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Plane
{
    public partial class Plane
    {
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

            SetVerticalMovementSymbol(gameTime);
            
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
        private void UpdateAltitude()
        {
            if (airTimeClearance == null)
                return;

            if (airTimeClearance.getAltitude() == null)
                return;

            float clearanceAltitude = airTimeClearance.getAltitude().GetAltitudeInFeet();
            float actualAltitude = this.altitude.GetAltitudeInFeet();

            bool clearanceAltitudeAndRealAltitudeAreDifferent = clearanceAltitude == actualAltitude;
            //update heading
            if (!clearanceAltitudeAndRealAltitudeAreDifferent)
            {
                if (Math.Abs(clearanceAltitude - actualAltitude) < 1)
                    altitude = airTimeClearance.getAltitude();
                else if (clearanceAltitude < actualAltitude)
                    altitude = altitude.Decrement(rateOfDescentPerPeriod);
                else
                    altitude = altitude.Increment(rateOfDescentPerPeriod);

                this.attributesHaveBeenUpdated = true;
            }
        }
        private void UpdateHeading()
        {
            if (airTimeClearance == null)
                return;

            if (airTimeClearance.getHeading() == null)
                return;
            float clearanceHeading = airTimeClearance.getHeading().GetHeadingInFloatDegrees();
            float actualHeading = this.heading.GetHeadingInFloatDegrees();

            bool clearanceHeadingAndHeadingAreDifferent = clearanceHeading == actualHeading;
            //update heading
            if (!clearanceHeadingAndHeadingAreDifferent)
            {
                if (Math.Abs(clearanceHeading - actualHeading) < 1)
                    heading = airTimeClearance.getHeading();
                else if (clearanceHeading < actualHeading)
                    heading = heading.Decrement(getTurningRadiusFromSpeed());
                else
                    heading = heading.Increment(getTurningRadiusFromSpeed());

                this.attributesHaveBeenUpdated = true;
            }
        }
        private void UpdateSpeed()
        {
            if (airTimeClearance == null)
                return;
            if (airTimeClearance.getSpeed() == null)
                return;

            float clearanceSpeed = airTimeClearance.getSpeed().ToKnotsFloat();
            float actualSpeed = this.speed.ToKnotsFloat();

            bool clearanceSpeedAndActualSpeedAreDifferent = clearanceSpeed == actualSpeed;

            if (!clearanceSpeedAndActualSpeedAreDifferent)
            {
                if (Math.Abs(clearanceSpeed - actualSpeed) < speedUpdateRate + 0.1)
                    speed = airTimeClearance.getSpeed();
                else if (clearanceSpeed < actualSpeed)
                    speed = speed.Decrement(speedUpdateRate);
                else
                    speed = speed.Increment(speedUpdateRate);

                this.attributesHaveBeenUpdated = true;
            }
        }

        public string getAnnouncementSpeech(string areaController)
        {
            return $"{this.flightNoAsStr} {areaController} entering your airspace";
        }

        public string getDepartureFromAirspaceSpeech(string areaController)
        {
            return $"{this.flightNoAsStr} {areaController} leaving your airspace";
        }

        public Rectangle GetHitbox()
        {
            return this.head.GetSquareLocationAsRectangle();
        }

        public Point GetCentreOfHead()
        {
            Rectangle rectangle = GetHitbox();
            return new Point(rectangle.X + head.getLength() / 2, rectangle.Y + head.getLength() / 2);
        }

        internal static IEqualityComparer<Plane> GetManhattenDistanceEqualityComparer()
        {
            return new ManhattenDistanceEqualityComparer();
        }

        private class ManhattenDistanceEqualityComparer : IEqualityComparer<Plane>
        {
            public bool Equals(Plane x, Plane y)
            {
                return x.GetVector3Location() == y.GetVector3Location();
            }

            public int GetHashCode([DisallowNull] Plane obj)
            {
                return obj.GetVector3Location().GetHashCode();
            }
        }

        private Vector3 GetVector3Location()
        {
            Vector2 centreOfHead = this.head.GetCentre();
            return new Vector3(centreOfHead.X, this.altitude.GetAltitudeInFeet(), centreOfHead.Y);
        }
    }
}
