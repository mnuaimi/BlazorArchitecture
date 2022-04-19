using AutoMapper;
using HelpDesk.Architecture.Infrastructure.Models.Identity;
using HelpDesk.Architecture.Application.Responses.Identity;

namespace HelpDesk.Architecture.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, HelpDeskRole>().ReverseMap();
        }
    }
}