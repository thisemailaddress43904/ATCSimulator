using ATC2027.ATC_Library.Clearance;
using ATC2027.Forms;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IUpdateable = ATC2027.Interfaces.IUpdateable;

namespace ATC2027.ATC_Library.CollectionRing
{
    public class CollectionRing : IAircraftCollectionRing, IUpdateable, IHasDevModeDrawableString
    {
        
        public Dictionary<string, Plane> planeCollection;
        private TimeSpan lastUpdate;
        private Plane? selectedPlane;

        public CollectionRing()
        {
            planeCollection = new Dictionary<string, Plane>();
        }

        public void AddPlane(Plane plane)
        {
            planeCollection.Add(plane.flightNoAsStr(), plane);
        }

        public void ApplyClearance(IClearance clearance, ref Plane plane)
        {
            plane.setClearance(ref clearance);
        }

        public void ClearAircraftCollection()
        {
            planeCollection.Clear();
        }

        public bool Contains(Plane plane)
        {
            return planeCollection.ContainsKey(plane.flightNoAsStr());
        }

        public IAircraftCollectionRing fromIATA_Code(string IATA_Code)
        {
            throw new NotImplementedException();
        }

        public IAircraftCollectionRing fromICAO_Code(string ICAO_Code)
        {
            throw new NotImplementedException();
        }

        public IList<Plane> getAircraftCollection()
        {
            return planeCollection.Values.ToList();
        }

        public IList<StatusBoardItem> getAircraftCollectionRingListItemsAsList()
        {
            List<StatusBoardItem> aircraftCollectionRingItem = [];

            foreach (var kvp in planeCollection) {
                aircraftCollectionRingItem.Add(kvp.Value.toStatusBoardItem());
            }

            return aircraftCollectionRingItem;
        }

        public string getDevModeDrawableString()
        {
            return $"{selectedPlane?.getDevModeDrawableString()}\nCollectionSize: {this.planeCollection.Count}";
        }

        public void RemovePlane(Plane plane)
        {
            planeCollection.Remove(plane.flightNoAsStr(), out _);
            
            if (selectedPlane != null || plane.flightNoAsStr() == selectedPlane.flightNoAsStr())
                selectedPlane = null;
        }

        public void Update(GameTime gameTime)
        {
            this.lastUpdate = gameTime.ElapsedGameTime;

            int xLowerLimit = 0, yLowerLimit = 0;
            int xUpperLimit = Constants.getWidthOfScreen;
            int yUpperLimit = Constants.getHeightOfScreen;

            int windowBuffer = 20;

            foreach (var kvp in planeCollection)
            {
                Vector2 location = kvp.Value.getLocation();
                
                //is too far left
                bool isOutsideOfTheBounds = (xLowerLimit - windowBuffer) > location.X;
                //is too far up
                if (!isOutsideOfTheBounds)
                    isOutsideOfTheBounds = (yLowerLimit - windowBuffer) > location.Y;
                //is too far right
                if (!isOutsideOfTheBounds)
                    isOutsideOfTheBounds = (xUpperLimit + windowBuffer) < location.X;
                //is too far down
                if (!isOutsideOfTheBounds)
                    isOutsideOfTheBounds = (yUpperLimit + windowBuffer) < location.Y;

                if (isOutsideOfTheBounds)
                    planeCollection.Remove(kvp.Key);
            }
        }

        public void DeselectPlane()
        {
            if (selectedPlane is not null)
            {
                planeCollection[selectedPlane.flightNoAsStr()].SetIsSelected(false);
                selectedPlane = null;
            }
                
        }

        public void SelectPlane(ref Plane plane)
        {
            this.selectedPlane = plane;
            plane?.SetIsSelected(true);
            selectedPlane = plane;
        }

        internal TimeSpan getLastUpdate()
        {
            return lastUpdate;
        }

        internal Plane? GetPlaneByFlightNumber(string flightNumber)
        {
            if (!planeCollection.TryGetValue(flightNumber, out Plane plane))
            {
                plane = null;
            }

            return plane;
        }

        ConcurrentDictionary<Plane, byte> IAircraftCollectionRing.getAircraftCollection()
        {
            throw new NotImplementedException();
        }
    }
}
