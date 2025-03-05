using RestSharp;

namespace PaytureTestTask.Application.Interfaces
{
    public interface IPaytureApi
    {
        Task<RestRequest> Pay();
        //Task<RestRequest> GetRequest();
    }
}
