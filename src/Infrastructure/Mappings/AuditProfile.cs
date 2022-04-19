using AutoMapper;
using HelpDesk.Architecture.Infrastructure.Models.Audit;
using HelpDesk.Architecture.Application.Responses.Audit;

namespace HelpDesk.Architecture.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}