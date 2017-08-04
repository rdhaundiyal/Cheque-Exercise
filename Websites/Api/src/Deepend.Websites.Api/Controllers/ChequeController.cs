using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Deepend.Core.Repository.Interface;


namespace Sample.Services.Cheque.Controllers
{
    public class ChequeController : ApiController
    {
        private readonly IRepository<Deepend.Services.Model.Cheque> _chequeRepository;
        public ChequeController(IRepository<Deepend.Services.Model.Cheque> chequeRepository)
        {
            _chequeRepository = chequeRepository;
        }
        // GET api/cheque
        public IEnumerable<Deepend.Services.Model.Cheque> Get()
        {
            return _chequeRepository.Get().OrderByDescending(k=>k.ChequeDate);
        }

        // GET api/cheque/5
        public Deepend.Services.Model.Cheque Get(string id)
        {
            return _chequeRepository.Get(id);
        }

       
    }
}
