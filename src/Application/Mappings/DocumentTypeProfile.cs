using AutoMapper;
using HelpDesk.Architecture.Application.Features.DocumentTypes.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.DocumentTypes.Queries.GetAll;
using HelpDesk.Architecture.Application.Features.DocumentTypes.Queries.GetById;
using HelpDesk.Architecture.Domain.Entities.Misc;

namespace HelpDesk.Architecture.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}