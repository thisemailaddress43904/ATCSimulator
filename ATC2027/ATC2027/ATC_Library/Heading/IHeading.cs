using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.ATC_Library.Heading
{
    public interface IHeading
    {
        public int GetHeadingInIntegerDegrees();
        public string ToString();
        public float GetHeadingInFloatDegrees();
        public IHeading Increment(float v = 1);
        public IHeading Decrement(float v = 1);
        double GetHeadingInFloatRadians();
    }
}
