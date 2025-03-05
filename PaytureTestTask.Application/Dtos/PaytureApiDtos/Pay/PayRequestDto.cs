using System.Text.Json.Serialization;

namespace PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay
{
    public class PayRequestDto
    {
        [JsonPropertyName("Key")]
        public string Key { get; set; } = "Merchant";

        [JsonPropertyName("Amount")]
        public int Amount { get; set; }

        [JsonPropertyName("PayInfo")]
        public PayInfo PayInfo { get; set; }
    }
}
