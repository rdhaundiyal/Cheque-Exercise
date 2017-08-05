using System.Collections.Generic;

namespace Deepend.Core.Repository.Interface
{
    /// <summary>
    /// Generic Reposirtory interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {

        IEnumerable<T> Get();
        T Get(string id);
    }
}