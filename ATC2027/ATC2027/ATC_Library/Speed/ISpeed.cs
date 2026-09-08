namespace ATC2027.Library.Speed
{
    public interface ISpeed
    {
        int ToKnots();
        ISpeed FromKnots();
        abstract string ToString();
        float ToKnotsFloat();
        ISpeed Increment(float val = 1);
        ISpeed Decrement(float val = 1);
    }
}