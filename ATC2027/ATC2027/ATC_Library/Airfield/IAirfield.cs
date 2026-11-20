using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using System.Collections;
using System.Collections.Generic;

namespace ATC2027.ATC_Library.Airfield
{
    public interface IAirfield : IHasDevModeDrawableString, IComponent
    {
        Altitude GetAltitude();
        IList<STAR> GetSTARList();
        IList<SID> GetSIDList();
        IRunway getRunwayByName(string name);
        string GetName();
        IList<string> getAllRunwayNames();
        Vector2? GetSpawnPointForDepartures(string runwayName);
    }
}