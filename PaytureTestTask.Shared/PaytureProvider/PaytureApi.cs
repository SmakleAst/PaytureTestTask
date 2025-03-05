using PaytureTestTask.Application.Dtos.PaytureApiDtos.GetState;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;
using PaytureTestTask.Application.Interfaces;
using RestSharp;

namespace PaytureTestTask.Shared.PaytureProvider
{
    public class PaytureApi : IPaytureApi
    {
        private const string _host = "sandbox3.payture.com";

        public async Task<RestResponse> GetState(GetStateRequestDto getStateRequestDto)
        {
            var client = new RestClient($"https://{_host}/api/Pay");
            var request = new RestRequest("", Method.Post);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            request.AddParameter("Key", getStateRequestDto.Key);
            request.AddParameter("OrderId", getStateRequestDto.OrderId);

            var response = await client.ExecuteAsync(request);

            return response;
        }

        public async Task<RestResponse> Pay(PayRequestDto payRequestDto)
        {
            var orderId = Guid.NewGuid();

            var client = new RestClient($"https://{_host}/api/Pay");
            var request = new RestRequest("", Method.Post);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            request.AddParameter("Key", payRequestDto.Key);
            request.AddParameter("Amount", payRequestDto.Amount);
            request.AddParameter("OrderId", orderId);
            request.AddParameter("PayInfo",
                $"PAN={payRequestDto.Key};" +
                $"EMonth={payRequestDto.PayInfo.EMonth};" +
                $"EYear={payRequestDto.PayInfo.EYear};" +
                $"CardHolder={payRequestDto.PayInfo.CardHolder};" +
                $"SecureCode={payRequestDto.PayInfo.SecureCode};" +
                $"OrderId={orderId};" +
                $"Amount={payRequestDto.PayInfo.Amount}"
            );

            var response = await client.ExecuteAsync(request);

            return response;
        }
    }
}
