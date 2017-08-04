using System.IO;
using Deepend.Core.Exception;
using Deepend.Core.Logging;

namespace Deepend.Core.Serialization
{
    public class XmlSerializer:ISerializer
    {
        private readonly ILogger _logger ;
        public XmlSerializer(ILogger logger)
        {
            _logger = logger;
        }
      
        public  T Deserialize<T>(string data) where T : class
        {
            try
            {
         
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(data))
            {
                return serializer.Deserialize(reader) as T;
            }
            }
            catch (System.Exception ex)
            {
                _logger.Log(ex);
                throw new SerializationException();
            }
            
        } 
    }
}