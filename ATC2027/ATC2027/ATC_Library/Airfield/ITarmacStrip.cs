using ATC2027.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATC2027.ATC_Library.Airfield
{
    public interface ITarmacStrip : IComponent
    {
        bool Contains2Runways();
        IRunway? getRunwayByName(string name);
        IEnumerable<IRunway> getRunways();
    }
}
