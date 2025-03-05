using MediatR;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;

namespace PaytureTestTask.Application.PaytureApiProvider.Commands.Pay
{
    public class PayCommand : IRequest<PayDetailsVm>
    {
        public string Key { get; set; }
        public int Amount { get; set; }
        public PayInfo PayInfo { get; set; }
    }
}
