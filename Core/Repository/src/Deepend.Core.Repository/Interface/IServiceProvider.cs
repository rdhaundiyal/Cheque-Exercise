using System.Collections.Generic;

namespace Deepend.Core.Repository.Interface
{
    /// <summary>
    /// Interface for service provider
    /// </summary>
    public interface IServiceProvider
    {
        T Get<T>(string id) where T : class;
        IEnumerable<T> Get<T>() where T : class;
    }
}