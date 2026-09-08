using System;

namespace ATC2027.ATC_Library
{
    public class VerticalMovement
    {
        public enum VerticalMovementEnum
        {
            up, down, constant, unknown
        }

        public static string ToString(VerticalMovementEnum verticalMovement)
        {
            switch (verticalMovement)
            {
                case VerticalMovementEnum.up:
                    return "^";
                case VerticalMovementEnum.down:
                    return "\\/";
                case VerticalMovementEnum.constant:
                    return "->";
                case VerticalMovementEnum.unknown:
                    return "?";
                default:
                    throw new Exception("Value not yet handled");
            }
        }
    }
    
}