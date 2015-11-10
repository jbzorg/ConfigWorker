namespace ConfigWorker.Interfaces
{
    public interface IDeserializer
    {
        T GetValue<T>(string value);
    }
}
