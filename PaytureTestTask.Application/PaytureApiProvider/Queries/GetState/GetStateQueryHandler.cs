using AutoMapper;
using MediatR;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.GetState;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;
using PaytureTestTask.Application.Interfaces;
using PaytureTestTask.Application.PaytureApiProvider.Commands.Pay;
using System.Xml.Serialization;

namespace PaytureTestTask.Application.PaytureApiProvider.Queries.GetState
{
    public class GetStateQueryHandler : IRequestHandler<GetStateQuery, GetStateDetailsVm>
    {
        private readonly IPaytureApi _paytureApi;
        private readonly IMapper _mapper;

        public GetStateQueryHandler(IPaytureApi paytureApi, IMapper mapper)
        {
            _paytureApi = paytureApi;
            _mapper = mapper;
        }

        public async Task<GetStateDetailsVm> Handle(GetStateQuery request, CancellationToken cancellationToken)
        {
            var getStateRequestDto = new GetStateRequestDto
            {
                Key = request.Key,
                OrderId = request.OrderId,
            };

            var response = await _paytureApi.GetState(getStateRequestDto);

            var serializer = new XmlSerializer(typeof(GetStateResponseDto));
            using var reader = new StringReader(response.Content);
            var getStateResponseDto = serializer.Deserialize(reader) as GetStateResponseDto;

            return _mapper.Map<GetStateDetailsVm>(getStateResponseDto);
        }
    }
}
