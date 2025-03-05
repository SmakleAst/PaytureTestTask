using AutoMapper;
using PaytureTestTask.Application.Common.Mappings;
using PaytureTestTask.Application.Dtos.PaytureApiDtos.Pay;
using System.Xml.Serialization;

namespace PaytureTestTask.Application.PaytureApiProvider.Commands.Pay
{
    public class PayDetailsVm : IMapWith<PayResponseDto>
    {
        public string OrderId { get; set; }
        public string Key { get; set; }
        public string Success { get; set; }
        public int? Amount { get; set; }
        public string? ACSUrl { get; set; }
        public string? PaReq { get; set; }
        public string? ThreeDSKey { get; set; }
        public string? ThreeDSVersion { get; set; }
        public string? FinalTerminal { get; set; }
        public string? AddInfo { get; set; }
        public string? ErrCode { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PayResponseDto, PayDetailsVm>()
                .ForMember(payVm => payVm.OrderId,
                    opt => opt.MapFrom(payDto => payDto.OrderId))
                .ForMember(payVm => payVm.Key,
                    opt => opt.MapFrom(payDto => payDto.Key))
                .ForMember(payVm => payVm.Success,
                    opt => opt.MapFrom(payDto => payDto.Success))
                .ForMember(payVm => payVm.Amount,
                    opt => opt.MapFrom(payDto => payDto.Amount))
                .ForMember(payVm => payVm.ACSUrl,
                    opt => opt.MapFrom(payDto => payDto.ACSUrl))
                .ForMember(payVm => payVm.PaReq,
                    opt => opt.MapFrom(payDto => payDto.PaReq))
                .ForMember(payVm => payVm.ThreeDSKey,
                    opt => opt.MapFrom(payDto => payDto.ThreeDSKey))
                .ForMember(payVm => payVm.ThreeDSVersion,
                    opt => opt.MapFrom(payDto => payDto.ThreeDSVersion))
                .ForMember(payVm => payVm.FinalTerminal,
                    opt => opt.MapFrom(payDto => payDto.FinalTerminal))
                .ForMember(payVm => payVm.AddInfo,
                    opt => opt.MapFrom(payDto => payDto.AddInfo))
                .ForMember(payVm => payVm.ErrCode,
                    opt => opt.MapFrom(payDto => payDto.ErrCode));
        }
    }
}
