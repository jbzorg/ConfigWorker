namespace ConfigWorker.Interfaces
{
    public interface IStore
    {
        string Get(string name);
        void Set(string name, string value);
    }
}
