using System.Xml.Serialization;

namespace PaytureTestTask.Application.Dtos.PaytureApiDtos.GetState
{
    [XmlRoot("GetState")]
    public class GetStateResponseDto
    {
        [XmlAttribute("Success")]
        public string Success { get; set; }

        [XmlAttribute("OrderId")]
        public string OrderId { get; set; }

        [XmlAttribute("Forwarded")]
        public string Forwarded { get; set; }

        [XmlAttribute("State")]
        public string? State { get; set; }

        [XmlAttribute("MerchantContract")]
        public string? MerchantContract { get; set; }

        [XmlAttribute("FinalTerminal")]
        public string? FinalTerminal { get; set; }

        [XmlAttribute("Amount")]
        public string? Amount { get; set; }

        [XmlAttribute("RRN")]
        public string? RRN { get; set; }

        [XmlAttribute("AddInfo")]
        public string? AddInfo { get; set; }

        [XmlAttribute("ErrCode")]
        public string? ErrCode { get; set; }
    }
}
