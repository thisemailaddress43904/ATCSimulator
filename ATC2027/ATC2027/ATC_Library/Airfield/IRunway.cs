
using ATC2027.ATC_Library.ControlAttribute.Heading;
using Microsoft.Xna.Framework;

namespace ATC2027.ATC_Library.Airfield
{
    public interface IRunway
    {
        IHeading getHeading();
        public string getShorthandName();
        public Vector2 getSpawnPoint();
    }
}
