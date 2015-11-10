namespace ConfigWorker.Interfaces
{
    public interface ISerializer
    {
        string GetValue<T>(T value);
    }
}
