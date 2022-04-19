using AutoMapper;
using HelpDesk.Architecture.Application.Requests.Identity;
using HelpDesk.Architecture.Application.Responses.Identity;
using HelpDesk.Architecture.Infrastructure.Models.Identity;

namespace HelpDesk.Architecture.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, HelpDeskRoleClaim>()
                .ForMember(nameof(HelpDeskRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(HelpDeskRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, HelpDeskRoleClaim>()
                .ForMember(nameof(HelpDeskRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(HelpDeskRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();
        }
    }
}