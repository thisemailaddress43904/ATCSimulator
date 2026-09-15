using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using ATC2027.ATC_Library.Clearance;
using ATC2027.Forms;
using ATC2027.Clearance;
using ATC2027.ATC_Library.Clearance.Interfaces;

namespace ATC2027.ATC_Library.CollectionRing
{
    public interface IAircraftCollectionRing
    {
        ConcurrentDictionary<Plane, byte> getAircraftCollection();
        public void AddPlane(Plane plane);
        public void RemovePlane(Plane plane);
        public void ClearAircraftCollection();
        public bool Contains(Plane plane);
        public void ApplyClearance(INonMutableClearance clearance, ref Plane plane);
        public IAircraftCollectionRing fromIATA_Code(string IATA_Code);
        public IAircraftCollectionRing fromICAO_Code(string ICAO_Code);

        public IList<StatusBoardItem> getAircraftCollectionRingListItemsAsList();
    }
}
