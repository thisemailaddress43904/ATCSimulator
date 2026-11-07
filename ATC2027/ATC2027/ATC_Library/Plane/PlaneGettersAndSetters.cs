using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;
using ATC2027.ATC_Library.Clearance.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Plane
{
    public partial class Plane
    {
        public bool getAttributesHaveBeenUpdated()
        {
            return this.attributesHaveBeenUpdated;
        }
        public void setAttributesHaveBeenUpdated(bool changeInAttributesHasBeenHandled)
        {
            this.attributesHaveBeenUpdated = changeInAttributesHasBeenHandled;
        }
        public string flightNoAsStr()
        {
            return flightNumber.ToString();
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

        public INonMutableClearance? getAirtimeClearance()
        {
            return this.airTimeClearance;
        }

        public Vector2 getLocation()
        {
            return location;
        }

        public void SetIsSelected(bool value)
        {
            this.isSelected = value;
        }
    }
}
