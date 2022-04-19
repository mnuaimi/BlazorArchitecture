using AutoMapper;
using HelpDesk.Architecture.Application.Interfaces.Chat;
using HelpDesk.Architecture.Application.Models.Chat;
using HelpDesk.Architecture.Infrastructure.Models.Identity;

namespace HelpDesk.Architecture.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<HelpDeskUser>>().ReverseMap();
        }
    }
}