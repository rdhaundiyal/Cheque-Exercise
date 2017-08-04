using System.Collections.Generic;
using System.Xml.Serialization;

namespace Deepend.Service.Provider.Dto
{
    [XmlRoot("cheques")]
  public  class ChequeXmlCollection
    {
        [XmlElement("cheque")]
        public List<ChequeXml> Cheques { get; set; }
    }
}
