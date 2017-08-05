using Deepend.Core.Repository.Base;
using Deepend.Core.Repository.Interface;
using Deepend.Services.Model;

namespace Deepend.Service.Provider.Repository
{

    /// <summary>
    /// Repository for cheque
    /// </summary>
    public class ChequeRepository : Repository<Cheque>
    {
        public ChequeRepository(IServiceProvider serviceProvider)
            : base(serviceProvider)
        { }
    }
}