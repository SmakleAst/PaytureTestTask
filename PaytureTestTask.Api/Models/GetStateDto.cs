using AutoMapper;
using PaytureTestTask.Application.Common.Mappings;
using PaytureTestTask.Application.PaytureApiProvider.Queries.GetState;

namespace PaytureTestTask.Api.Models
{
    public class GetStateDto : IMapWith<GetStateQuery>
    {
        public string Key { get; set; }
        public string OrderId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetStateDto, GetStateQuery>()
                .ForMember(getStateQuery => getStateQuery.Key,
                    opt => opt.MapFrom(getStateDto => getStateDto.Key))
                .ForMember(getStateQuery => getStateQuery.OrderId,
                    opt => opt.MapFrom(getStateDto => getStateDto.OrderId));
        }
    }
}
