using System.IO;
using System.Xml.Serialization;

namespace Deepend.Core.Serialization
{
    public class XmlSerializer:ISerializer
    {
      
        public  T Deserialize<T>(string data) where T : class
        {
            var xRoot = new XmlRootAttribute { ElementName = "cheques" };
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T), xRoot);



            using (TextReader reader = new StringReader(data))
            {
                return serializer.Deserialize(reader) as T;
            }
        } 
    }
}