using PaytureTestTask.Application.Dtos.PaytureApiDtos.GetState;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;
using RestSharp;

namespace PaytureTestTask.Application.Interfaces
{
    public interface IPaytureApi
    {
        Task<RestResponse> Pay(PayRequestDto payRequestDto);
        Task<RestResponse> GetState(GetStateRequestDto getStateRequestDto);
    }
}
