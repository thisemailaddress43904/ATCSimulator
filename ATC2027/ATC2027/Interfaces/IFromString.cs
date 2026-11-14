namespace ATC2027.Interfaces
{
    public interface IFromString<T> where T : IFromString<T>
    {
        public T fromString(string value);
    }
}