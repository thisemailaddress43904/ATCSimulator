namespace ATC2027.ExtensionClasses
{
    public static class MathExtension
    {
        public static bool IsANumberWithInRange(string text, float lowerLimitInclusive, float upperLimitInclusive)
        {
            float f;
            try
            {
                f = float.Parse(text);

                return lowerLimitInclusive <= f && f <= upperLimitInclusive;
            }
            catch { return false; }
        }
        public static float Map(float yAsAPercentageAcrossXDomain, float smallXValue, float bigXValue) {
            float result = 0;
            
            result = bigXValue - smallXValue;
            result /= 100;
            result *= yAsAPercentageAcrossXDomain;
            result += smallXValue;

            return result;
        }
        public static float Map(double yAsAPercentageAcrossXDomain, double smallXValue, double bigXValue)
        {
            double result = 0;

            result = bigXValue - smallXValue;
            result /= 100;
            result *= yAsAPercentageAcrossXDomain;
            result += smallXValue;

            return (float)result;
        }
    }
}
