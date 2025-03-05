using AutoMapper;
using MediatR;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;
using PaytureTestTask.Application.Interfaces;
using System.Xml.Serialization;

namespace PaytureTestTask.Application.PaytureApiProvider.Commands.Pay
{
    public class PayCommandHandler : IRequestHandler<PayCommand, PayDetailsVm>
    {
        private readonly IPaytureApi _paytureApi;
        private readonly IMapper _mapper;

        public PayCommandHandler(IPaytureApi paytureApi, IMapper mapper)
        {
            _paytureApi = paytureApi;
            _mapper = mapper;
        }
        
        public async Task<PayDetailsVm> Handle(PayCommand request, CancellationToken cancellationToken)
        {
            var payRequestDto = new PayRequestDto
            {
                Key = request.Key,
                Amount = request.Amount,
                PayInfo = request.PayInfo,
            };
             
            var response = await _paytureApi.Pay(payRequestDto);

            var serializer = new XmlSerializer(typeof(PayResponseDto));
            using var reader = new StringReader(response.Content);
            var payResponseDto = serializer.Deserialize(reader) as PayResponseDto;

            return _mapper.Map<PayDetailsVm>(payResponseDto);
        }
    }
}
