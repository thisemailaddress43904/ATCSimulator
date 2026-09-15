using System.Collections.Generic;

namespace ATC2027.ATC_Library.Clearance
{
    public interface IHasClearance
    {
        public string ToString();
        public Dictionary<string, string> clearanceAttributesAsDictionary();
    }
}