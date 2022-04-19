using AutoMapper;
using HelpDesk.Architecture.Infrastructure.Models.Identity;
using HelpDesk.Architecture.Application.Responses.Identity;

namespace HelpDesk.Architecture.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, HelpDeskUser>().ReverseMap();
            CreateMap<ChatUserResponse, HelpDeskUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}