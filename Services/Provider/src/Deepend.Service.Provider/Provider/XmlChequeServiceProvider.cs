using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using AutoMapper;
using Deepend.Core.Exception;
using Deepend.Core.Logging;
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
        private readonly string _xmlDataFilePath;
        private readonly ILogger _logger;
        public XmlChequeServiceProvider(string xmlDataFilePath, ISerializer serializer, IMapper mapper, ILogger logger)
        {
            _xmlDataFilePath = xmlDataFilePath;
            _mapper = mapper;
            _serializer = serializer;
            _logger = logger;
        }
        public T Get<T>(string id) where T : class
        {
            try
            {
                var result = GetDeserializedCheque();
                var cheque = result.Cheques.FirstOrDefault(k => k.ID == id);
                return _mapper.Map<ChequeXml, Cheque>(cheque) as T;
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
                throw new ServiceException();
            }
        }

        public IEnumerable<T> Get<T>() where T : class
        {
            try
            {
                var result = GetDeserializedCheque();
                return result.Cheques.Select(cheque => _mapper.Map<ChequeXml, Cheque>(cheque) as T).ToList();
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
                throw new ServiceException();
            }
        }

        private ChequeXmlCollection GetDeserializedCheque()
        {
            var contentxml = new XmlDocument();
            contentxml.Load(_xmlDataFilePath);
            return _serializer.Deserialize<ChequeXmlCollection>(contentxml.InnerXml);

        }
    }
}
