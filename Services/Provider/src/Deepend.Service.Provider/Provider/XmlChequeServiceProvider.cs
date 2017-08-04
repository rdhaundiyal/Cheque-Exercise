using System.Collections.Generic;
using System.Linq;
using System.Xml;
using AutoMapper;
using Deepend.Service.Provider.Configuration;
using Deepend.Service.Provider.Dto;
using Deepend.Services.Model;
using XmlSerializer = Deepend.Core.Serialization.XmlSerializer;

namespace Deepend.Service.Provider.Provider
{
    public class XmlChequeServiceProvider : Core.Repository.Interface.IServiceProvider
    {
        private readonly IMapper _mapper;
        public XmlChequeServiceProvider(IMapper mapper)
        {
            _mapper = mapper;
        }
        public T Get<T>(string id) where T : class
        {

            var contentxml = new XmlDocument();
            contentxml.Load(Settings.ChequeDataXmlPath);

            var result = XmlSerializer.Deserialize<ChequeXmlCollection>(contentxml.InnerXml);


            var cheque = result.Cheques.FirstOrDefault(k => k.ID == id);

            return _mapper.Map<ChequeXml, Cheque>(cheque) as T;
        }

        public IEnumerable<T> Get<T>() where T : class
        {
            var contentxml = new XmlDocument();
            contentxml.Load(Settings.ChequeDataXmlPath);

            var result = XmlSerializer.Deserialize<ChequeXmlCollection>(contentxml.InnerXml);
            return result.Cheques.Select(cheque => _mapper.Map<ChequeXml, Cheque>(cheque) as T).ToList();
        }
    }
}
