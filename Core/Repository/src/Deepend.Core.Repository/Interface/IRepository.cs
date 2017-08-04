using System.Collections.Generic;

namespace Deepend.Core.Repository.Interface
{
    public interface IRepository<T>
    {

        IEnumerable<T> Get();
        T Get(string id);
    }
}