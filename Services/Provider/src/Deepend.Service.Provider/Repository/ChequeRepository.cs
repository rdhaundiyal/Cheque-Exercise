using Deepend.Core.Repository.Base;
using Deepend.Core.Repository.Interface;
using Deepend.Services.Model;

namespace Deepend.Service.Provider.Repository
{
    public class ChequeRepository : Repository<Cheque>
    {
        public ChequeRepository(IServiceProvider serviceProvider)
            : base(serviceProvider)
        { }
    }
}