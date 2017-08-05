namespace Deepend.Core.Serialization
{

    /// <summary>
    /// Serializer interface
    /// </summary>
    public interface ISerializer
    {
        T Deserialize<T>(string data) where T : class;
    }
}