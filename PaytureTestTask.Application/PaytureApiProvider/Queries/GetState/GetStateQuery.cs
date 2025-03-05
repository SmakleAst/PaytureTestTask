using MediatR;

namespace PaytureTestTask.Application.PaytureApiProvider.Queries.GetState
{
    public class GetStateQuery : IRequest<GetStateDetailsVm>
    {
        public string Key { get; set; }
        public string OrderId { get; set; }
    }
}
