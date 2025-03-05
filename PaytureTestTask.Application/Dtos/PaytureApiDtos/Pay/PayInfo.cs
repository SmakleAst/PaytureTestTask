using System.Text.Json.Serialization;

namespace PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay
{
    public class PayInfo
    {
        [JsonPropertyName("PAN")]
        public string PAN { get; set; }

        [JsonPropertyName("EMonth")]
        public string EMonth { get; set; }

        [JsonPropertyName("EYear")]
        public string EYear { get; set; }

        [JsonPropertyName("CardHolder")]
        public string CardHolder { get; set; }

        [JsonPropertyName("SecureCode")]
        public string SecureCode { get; set; }

        [JsonPropertyName("Amount")]
        public int Amount { get; set; }
    }
}
}
