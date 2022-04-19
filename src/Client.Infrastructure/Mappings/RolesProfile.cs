using AutoMapper;
using HelpDesk.Architecture.Application.Requests.Identity;
using HelpDesk.Architecture.Application.Responses.Identity;

namespace HelpDesk.Architecture.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}