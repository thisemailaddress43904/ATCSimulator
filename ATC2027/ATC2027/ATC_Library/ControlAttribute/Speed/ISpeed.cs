namespace ATC2027.ATC_Library.ControlAttribute.Speed
{
    public interface ISpeed
    {
        public int ToKnots();
        public float ToKnotsFloat();
        public ISpeed Increment(float val = 1);
        public ISpeed Decrement(float val = 1);
    }
}