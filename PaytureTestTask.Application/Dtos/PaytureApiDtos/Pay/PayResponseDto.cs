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
        public string? Amount { get; set; }

        [XmlAttribute("ACSUrl")]
        public string? ACSUrl { get; set; }

        [XmlAttribute("PaReq")]
        public string? PaReq { get; set; }

        [XmlAttribute("ThreeDSKey")]
        public string? ThreeDSKey { get; set; }

        [XmlAttribute("ThreeDSVersion")]
        public string? ThreeDSVersion { get; set; }

        [XmlAttribute("FinalTerminal")]
        public string? FinalTerminal { get; set; }

        [XmlAttribute("AddInfo")]
        public string? AddInfo { get; set; }

        [XmlAttribute("ErrCode")]
        public string? ErrCode { get; set; }
    }
}
