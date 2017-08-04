using System.Collections.Generic;
using System.Linq;
using System.Xml;
using AutoMapper;
using Deepend.Core.Serialization;
using Deepend.Service.Provider.Dto;
using Deepend.Services.Model;
using XmlSerializer = Deepend.Core.Serialization.XmlSerializer;

namespace Deepend.Service.Provider.Provider
{
    public class XmlChequeServiceProvider : Core.Repository.Interface.IServiceProvider
    {
        private readonly IMapper _mapper;
        private readonly ISerializer _serializer;
        private readonly string _xmlDataFilePath ;
        public XmlChequeServiceProvider(string xmlDataFilePath,ISerializer serializer, IMapper mapper)
        {
            _xmlDataFilePath = xmlDataFilePath;
            _mapper = mapper;
            _serializer = serializer;
        }
        public T Get<T>(string id) where T : class
        {

         ;

            var result = GetDeserializedCheque();
            var cheque = result.Cheques.FirstOrDefault(k => k.ID == id);
            return _mapper.Map<ChequeXml, Cheque>(cheque) as T;
        }

        public IEnumerable<T> Get<T>() where T : class
        {
            var result = GetDeserializedCheque();
            return result.Cheques.Select(cheque => _mapper.Map<ChequeXml, Cheque>(cheque) as T).ToList();
        }

        private ChequeXmlCollection GetDeserializedCheque()
        {
            var contentxml = new XmlDocument();
            contentxml.Load(_xmlDataFilePath);
            return _serializer.Deserialize<ChequeXmlCollection>(contentxml.InnerXml);
            
        }
    }
}
