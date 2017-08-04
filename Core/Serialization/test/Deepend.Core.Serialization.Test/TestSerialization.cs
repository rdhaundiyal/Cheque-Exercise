using System;
using System.Xml.Serialization;
using Deepend.Core.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Deepend.Core.Serialization.Test
{
    [TestClass]
    public class TestSerialization
    {
        private ISerializer _serializer;
        [TestInitialize]
        public void SetUp()
        {
             var mock = new Mock<ILogger>();
        _serializer=new XmlSerializer(mock.Object);
        }
        [TestCleanup]
        public void TearDown()
        { }
        [TestMethod]
        public void TestDeserialize()
        {
          
            var xmlData = "<cheque><id>ICICI00345678</id><name>Leo Tolstoy</name><date>12/05/1953</date><currency>$</currency><amount>756.89</amount></cheque>";
            var result = _serializer.Deserialize<TestXmlClass>(xmlData);
            Assert.AreEqual("ICICI00345678", result.ID);
        }

        [TestMethod]
        [ExpectedException(typeof (Deepend.Core.Exception.SerializationException))]
        public void TestDeserializeException()
        {
            var xmlData = "some garbageValue";
            var result = _serializer.Deserialize<TestXmlClass>(xmlData);

        }
    }

     [XmlRoot("cheque")]
    public class TestXmlClass
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
