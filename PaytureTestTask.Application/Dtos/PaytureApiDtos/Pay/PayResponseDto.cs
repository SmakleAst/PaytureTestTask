using System.Xml.Serialization;

namespace PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay
{
    [XmlRoot("Pay")]
    public class PayResponseDto
    {
        [XmlAttribute("OrderId")]
        public string OrderId { get; set; }

        [XmlAttribute("Key")]
        public string Key { get; set; }

        [XmlAttribute("Success")]
        public string Success { get; set; }

        [XmlAttribute("Amount")]
        public int Amount { get; set; }
    }
}
