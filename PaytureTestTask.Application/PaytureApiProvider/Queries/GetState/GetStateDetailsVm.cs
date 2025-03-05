using AutoMapper;
using PaytureTestTask.Application.Common.Mappings;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.GetState;

namespace PaytureTestTask.Application.PaytureApiProvider.Queries.GetState
{
    public class GetStateDetailsVm : IMapWith<GetStateResponseDto>
    {
        public string Success { get; set; }
        public string OrderId { get; set; }
        public string Forwarded { get; set; }
        public string? State { get; set; }
        public string? MerchantContract { get; set; }
        public string? FinalTerminal { get; set; }
        public string? Amount { get; set; }
        public string? RRN { get; set; }
        public string? AddInfo { get; set; }
        public string? ErrCode { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetStateResponseDto, GetStateDetailsVm>()
                .ForMember(getStateVm => getStateVm.Success,
                    opt => opt.MapFrom(getStateDto => getStateDto.Success))
                .ForMember(getStateVm => getStateVm.OrderId,
                    opt => opt.MapFrom(getStateDto => getStateDto.OrderId))
                .ForMember(getStateVm => getStateVm.Forwarded,
                    opt => opt.MapFrom(getStateDto => getStateDto.Forwarded))
                .ForMember(getStateVm => getStateVm.State,
                    opt => opt.MapFrom(getStateDto => getStateDto.State))
                .ForMember(getStateVm => getStateVm.MerchantContract,
                    opt => opt.MapFrom(getStateDto => getStateDto.MerchantContract))
                .ForMember(getStateVm => getStateVm.FinalTerminal,
                    opt => opt.MapFrom(getStateDto => getStateDto.FinalTerminal))
                .ForMember(getStateVm => getStateVm.Amount,
                    opt => opt.MapFrom(getStateDto => getStateDto.Amount))
                .ForMember(getStateVm => getStateVm.RRN,
                    opt => opt.MapFrom(getStateDto => getStateDto.RRN))
                .ForMember(getStateVm => getStateVm.AddInfo,
                    opt => opt.MapFrom(getStateDto => getStateDto.AddInfo))
                .ForMember(getStateVm => getStateVm.ErrCode,
                    opt => opt.MapFrom(getStateDto => getStateDto.ErrCode));
        }
    }
}
