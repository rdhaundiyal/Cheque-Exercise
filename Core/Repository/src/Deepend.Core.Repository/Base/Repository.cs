using Deepend.Core.Repository.Interface;

namespace Deepend.Core.Repository.Base
{
    /// <summary>
    /// Base repository to retrieve data through service provider
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly IServiceProvider _serviceProvider;
        protected Repository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public System.Collections.Generic.IEnumerable<T> Get()
        {
            return _serviceProvider.Get<T>();
        }

        public T Get(string id)
        {
            return _serviceProvider.Get<T>(id);
        }
    }
}