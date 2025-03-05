using AutoMapper;
using PaytureTestTask.Application.Common.Mappings;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;
using PaytureTestTask.Application.PaytureApiProvider.Commands.Pay;

namespace PaytureTestTask.Api.Models
{
    public class PayDto : IMapWith<PayCommand>
    {
        public string Key { get; set; }
        public int Amount { get; set; }
        public PayInfo PayInfo { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PayDto, PayCommand>()
                .ForMember(payCommand => payCommand.Key,
                    opt => opt.MapFrom(payDto => payDto.Key))
                .ForMember(payCommand => payCommand.Amount,
                    opt => opt.MapFrom(payDto => payDto.Amount))
                .ForMember(payCommand => payCommand.PayInfo,
                    opt => opt.MapFrom(payDto => payDto.PayInfo));
        }
    }
}
