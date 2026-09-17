using ATC2027.ATC_Library.Clearance.Interfaces;
using System.Collections.Generic;

namespace ATC2027.ATC_Library.Clearance
{
    public interface IHasNullableNonMutableClearance
    {
        public string ToString();
        public Dictionary<string, string> clearanceAttributesAsDictionary();
        public INonMutableClearance? GetClearance();
    }
}