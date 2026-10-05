using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Controls.UserControl.Abstract;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Airfield
{
    public class Airfield : IAirfield, IComponent, IHasDevModeDrawableString
    {
        private string _name;
        private string _shorthandName;
        private Tuple<float, float> _location;
        private IList<Runway> _runwayList;
        public static int spacingBetweenRunways = 2;
        private Altitude altitude;
        private IList<STAR> starList;
        private IList<SID> sidList;
        
        public Airfield(string name, string shorthandName, Tuple<float, float> location, IList<Runway> runwayHeadings, Altitude altitude, IList<STAR> starList, IList<SID> sidList)
        {
            this._name = name;
            this._location = location;
            this._runwayList = runwayHeadings;
            this.altitude = altitude;
            this.starList = starList;
            this.sidList = sidList;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (Runway runway in this._runwayList)
            {
                runway.Draw(gameTime, spriteBatch);
            }
        }

        public string getDevModeDrawableString()
        {
            if (_runwayList == null || _runwayList.Count == 0)
            {
                return "Runway list is empty or null";
            }

            StringBuilder stringBuilder = new StringBuilder();
            if (_runwayList.Count > 0)
                stringBuilder.Append($"The runway ").
                    Append(_name).
                    Append(" exists at ").
                    Append($"long:{_location.Item1}  lat:{_location.Item2}").
                    Append(" and has the runway");
                
            if (_runwayList.Count > 1)
                stringBuilder.Append("s");
            
            foreach(IRunway runway in _runwayList)
            {
                stringBuilder.Append(" ");
                stringBuilder.Append(runway.getShorthandName1());
                if (runway.getShorthandName2() != null)
                {
                    stringBuilder.Append(" and ").AppendLine(runway.getShorthandName2());
                }
            }
            stringBuilder.Append("starList: ").AppendLine(starList == null ? "null" : $"has {starList.Count} items");
            stringBuilder.Append("sidList: ").AppendLine(sidList == null ? "null" : $"has {sidList.Count} items");
            
            return stringBuilder.ToString();
        }

        public void Update(GameTime gameTime)
        {

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
    }
}
