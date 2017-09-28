using System;
using System.Net.Http;
using System.Web.UI;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HttpClientSample
{
    [Serializable, XmlRoot(ElementName = "QQQ",DataType ="string", IsNullable = true, Namespace ="www.yandex.ru")]
    public class Product
    {
        public string Id { get; set; }
        [XmlElement("SuperName")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
