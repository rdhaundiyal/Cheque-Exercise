using System.Xml.Serialization;

namespace Deepend.Service.Provider.Dto
{
    public class ChequeXml
    {
        [XmlElement("id")]
        public string ID { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("date")]
        public string ChequeDate { get; set; }
        [XmlElement("currency")]
        public string Currency { get; set; }
        [XmlElement("amount")]
        public decimal Amount { get; set; }  
    }
}