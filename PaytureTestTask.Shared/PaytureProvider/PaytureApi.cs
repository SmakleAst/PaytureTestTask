using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;
using PaytureTestTask.Application.Interfaces;
using RestSharp;

namespace PaytureTestTask.Shared.PaytureProvider
{
    public class PaytureApi : IPaytureApi
    {
        private const string _host = "sandbox3.payture.com";

        public async Task<RestResponse> Pay(PayRequestDto payRequestDto)
        {
            var orderId = Guid.NewGuid();

            var client = new RestClient($"https://{_host}/api/Pay");
            var request = new RestRequest("", Method.Post);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            request.AddParameter("Key", "Merchant");
            request.AddParameter("Amount", "12541");
            request.AddParameter("OrderId", $"{orderId}");
            request.AddParameter("PayInfo",
                "PAN=4111111111100031;" +
                "EMonth=12;" +
                "EYear=22;" +
                "CardHolder=Ivan Ivanov;" +
                "SecureCode=123;" +
                $"OrderId={orderId};" +
                "Amount=12541"
            );

            var response = await client.ExecuteAsync(request);

            return response;
        }
    }
}
