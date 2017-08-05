using System.Collections.Generic;
using System.Xml.Serialization;

namespace Deepend.Service.Provider.Dto
{
    /// <summary>
    /// DTO for cheque collection
    /// </summary>
    [XmlRoot("cheques")]
  public  class ChequeXmlCollection
    {
        [XmlElement("cheque")]
        public List<ChequeXml> Cheques { get; set; }
    }
}
