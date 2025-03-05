using AutoMapper;
using PaytureTestTask.Application.Common.Mappings;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;

namespace PaytureTestTask.Application.PaytureApiProvider.Commands.Pay
{
    public class PayDetailsVm : IMapWith<PayResponseDto>
    {
        public string OrderId { get; set; }
        public string Key { get; set; }
        public string Success { get; set; }
        public int Amount { get; set; }

        public void Mappnig(Profile profile)
        {
            profile.CreateMap<PayResponseDto, PayDetailsVm>()
                .ForMember(payVm => payVm.OrderId,
                    opt => opt.MapFrom(payDto => payDto.OrderId))
                .ForMember(payVm => payVm.Key,
                    opt => opt.MapFrom(payDto => payDto.Key))
                .ForMember(payVm => payVm.Success,
                    opt => opt.MapFrom(payDto => payDto.Success))
                .ForMember(payVm => payVm.Amount,
                    opt => opt.MapFrom(payDto => payDto.Amount));
        }
    }
}
