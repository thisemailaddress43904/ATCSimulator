using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.Plane;
using ATC2027.Clearance;
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
using System.Windows.Forms;
using IUpdateable = ATC2027.Interfaces.IUpdateable;

namespace ATC2027.ATC_Library.CollectionRing
{
    public class CollectionRing : IAircraftCollectionRing, IUpdateable, IHasDevModeDrawableString
    {
        public IAirfield airfield;
        public Dictionary<string, Plane.Plane> planeCollection;
        private TimeSpan lastUpdate;
        private Plane.Plane? selectedPlane;
        public event EventHandler PlaneRemoved;

        public CollectionRing(ref IAirfield airfield)
        {
            planeCollection = new Dictionary<string, Plane.Plane>();
            this.airfield = airfield;
        }

        public async void AddPlane(Plane.Plane plane)
        {
            planeCollection.Add(plane.flightNoAsStr(), plane);
            Speech.TTS.TextToSpeech.Speak(plane.getAnnouncementSpeech("tower"));
        }

        public void ApplyClearance(INonMutableDepartureClearance clearance, ref Plane.Plane plane)
        {
            if (plane.CanBeConsideredForTakeoffClearance)
            {
                plane.SetDepartureClearance(clearance);
            }
            else
                throw new Exception("Not implemented");
        }

        public void ApplyClearance(INonMutableArrivalClearance clearance, ref Plane.Plane plane)
        {
            if (plane.CanBeConsideredForTakeoffClearance)
            {
                plane.SetArrivalClearance(clearance);
            }
            else
                throw new Exception("Not implemented");
        }

        public void ApplyClearance(INonMutableClearance clearance, ref Plane.Plane plane)
        {
            try
            {
                plane.setClearance(ref clearance);
            }
            catch (NullReferenceException nre)
            {
                //this happens when the plane has already been removed from the collection ring
                //do nothing to handle this
            }
            
        }

        public void ClearAircraftCollection()
        {
            planeCollection.Clear();
        }

        public bool Contains(Plane.Plane plane)
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

        public IList<Plane.Plane> getAircraftCollection()
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
            if (selectedPlane != null)
                return $"{selectedPlane?.getDevModeDrawableString()}\nCollectionSize: {this.planeCollection.Count}";
            else
                return $"CollectionSize: {this.planeCollection.Count}";
        }

        public void RemovePlane(Plane.Plane plane)
        {
            planeCollection.Remove(plane.flightNoAsStr(), out _);
            
            if (selectedPlane != null || plane.flightNoAsStr() == selectedPlane.flightNoAsStr())
                selectedPlane = null;

            Speech.TTS.TextToSpeech.Speak(plane.getDepartureFromAirspaceSpeech("tower"));

            PlaneRemoved.Invoke(this, EventArgs.Empty);
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


                //collision detection (n^2 time complexity where n is the number of planes)
                //Could be made more efficient by ordering a list with a heuristic and checking if the nearest few planes collide

                //list ordered by distance from selected plane (manhatten distance in 3 dimensions)
                //    -> does selected plane collide with the first plane?
                //        No -> neither do the others,
                //        Yes -> there could be a double plane or more collision (that would be excedingly rare)
                //
                // ordering a list can be done in log n efficiency
                //this algorithms efficiency would n * log n where n is the number of the planes in the list

                foreach (var kvp2 in planeCollection)
                {
                    if (kvp.Key == kvp2.Key)
                        continue;

                    if (kvp2.Value.GetHitbox().Contains(kvp.Value.GetCentreOfHead()))
                    {
                        MessageBox.Show($"Collision between {kvp2.Key} and {kvp.Key} at {kvp2.Value.GetCentreOfHead().ToString()}", "Collision", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void DeselectPlane()
        {
            if (selectedPlane is not null)
            {
                try
                {
                    planeCollection[selectedPlane.flightNoAsStr()].SetIsSelected(false);
                }
                catch (Exception ex)
                {
                    //the key value pair has already been removed from the dictionary and so its attributes can not be modified via the dictionary
                }
                
                selectedPlane = null;
            }
                
        }

        public void SelectPlane(ref Plane.Plane plane)
        {
            this.selectedPlane = plane;
            plane?.SetIsSelected(true);
            selectedPlane = plane;
        }

        internal TimeSpan getLastUpdate()
        {
            return lastUpdate;
        }

        internal Plane.Plane? GetPlaneByFlightNumber(string flightNumber)
        {
            if (!planeCollection.TryGetValue(flightNumber, out Plane.Plane plane))
            {
                plane = null;
            }

            return plane;
        }

        ConcurrentDictionary<Plane.Plane, byte> IAircraftCollectionRing.getAircraftCollection()
        {
            throw new NotImplementedException();
        }

        /**
         * Transfers a plane from this collection ring to another collection ring as well as removes it from this collection ring.
         * 
         * @param plane The plane to be transferred.
         * @param collectionRing The target collection ring to which the plane will be added.
         */
        public void TransferPlaneToCollectionRing(ref Plane.Plane plane, ref IAircraftCollectionRing collectionRing)
        {
            collectionRing.AddPlane(plane);
            this.RemovePlane(plane);
        }
    }
}
