using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATC2027.ATC_Library.Airfield
{
    public class Airfield : IAirfield
    {
        private string _name;
        private Tuple<float, float> _location;
        private IList<ITarmacStrip> _tarmacList;
        public static int spacingBetweenRunways = 2;
        private Altitude altitude;
        private IList<STAR> starList;
        private IList<SID> sidList;
        
        public Airfield(string name, string shorthandName, Tuple<float, float> location, IList<ITarmacStrip> tarmacStrips, Altitude altitude, IList<STAR> starList, IList<SID> sidList)
        {
            this._name = name;
            this._location = location;
            this._tarmacList = tarmacStrips;
            this.altitude = altitude;
            this.starList = starList;
            this.sidList = sidList;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (ITarmacStrip ts in _tarmacList)
            {
                ts.Draw(gameTime, spriteBatch);
            }

            foreach (SID sid in sidList) { 
                sid.Draw(gameTime, spriteBatch);
            }

            foreach(STAR star in starList)
            {
                star.Draw(gameTime, spriteBatch);
            }
        }

        public string getDevModeDrawableString()
        {
            if (_tarmacList == null || _tarmacList.Count == 0)
            {
                return "_tarmacList list is empty or null";
            }

            StringBuilder stringBuilder = new StringBuilder();
            if (_tarmacList.Count > 0)
                stringBuilder.Append($"The tarmac ").
                    Append(_name).
                    Append(" exists at ").
                    Append($"long:{_location.Item1}  lat:{_location.Item2}").
                    Append(" and has the runway");
            
            if (_tarmacList.Count >= 2 || _tarmacList.Count == 1 && _tarmacList.First().Contains2Runways())
                stringBuilder.Append("s");
            
            foreach(ITarmacStrip tarmacStrip in _tarmacList)
            {
                foreach (IRunway runway in tarmacStrip.getRunways())
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(runway.getShorthandName());
                }
            }
            
            stringBuilder.Append("starList: ").AppendLine(starList == null ? "null" : $"has {starList.Count} items");
            stringBuilder.Append("sidList: ").AppendLine(sidList == null ? "null" : $"has {sidList.Count} items");
            
            return stringBuilder.ToString();
        }

        public void Update(GameTime gameTime)
        {
            foreach (ITarmacStrip ts in _tarmacList)
            {
                ts.Update(gameTime);
            }

            foreach (SID sid in sidList)
            {
                sid.Update(gameTime);
            }

            foreach (STAR star in starList)
            {
                star.Update(gameTime);
            }
        }

        public Altitude GetAltitude()
        {
            return this.altitude;
        }

        public IList<STAR> GetSTARList()
        {
            return this.starList;
        }

        public IList<SID> GetSIDList()
        {
            return this.sidList;
        }

        public IRunway getRunwayByName(string name)
        {
            IList<IRunway> runwayList = [];

            foreach (ITarmacStrip tarmacStrip in _tarmacList)
            {
                foreach (IRunway runway in tarmacStrip.getRunways())
                {
                    runwayList.Add(runway);
                }
            }
            
            runwayList = runwayList.OrderBy(x => x.getShorthandName() == name).ToList();

            if (runwayList.Count == 0)
            {
                return null;
            }
            if (runwayList.Last().getShorthandName() == name)
            {
                return runwayList.Last();
            }
            return null;
        }

        public Vector2? GetSpawnPointForDepartures(string name)
        {
            IList<IRunway> runwayList = [];

            foreach (ITarmacStrip tarmacStrip in _tarmacList)
            {
                foreach (IRunway runway in tarmacStrip.getRunways())
                {
                    runwayList.Add(runway);
                }
            }

            runwayList = runwayList.OrderBy(x => x.getShorthandName() == name).ToList();

            if (runwayList.Count == 0)
            {
                return null;
            }
            if (runwayList.Last().getShorthandName() == name)
            {
                return runwayList.Last().getSpawnPoint();
            }
            return null;
        }


        public string GetName()
        {
            return this._name;
        }

        public IList<string> getAllRunwayNames()
        {
            IList<string> runwayNames = [];

            foreach(TarmacStrip ts in _tarmacList)
                foreach (Runway runway in ts.getRunways())
                    runwayNames.Add(runway.getShorthandName());

            return runwayNames;
        }
    }
}
