using AutoMapper;
using HelpDesk.Architecture.Application.Features.Documents.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.Documents.Queries.GetById;
using HelpDesk.Architecture.Domain.Entities.Misc;

namespace HelpDesk.Architecture.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}