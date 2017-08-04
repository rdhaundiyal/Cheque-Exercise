namespace Deepend.Core.Serialization
{
    public interface ISerializer
    {
        T Deserialize<T>(string data) where T : class;
    }
}