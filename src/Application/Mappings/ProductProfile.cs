using AutoMapper;
using HelpDesk.Architecture.Application.Features.Products.Commands.AddEdit;
using HelpDesk.Architecture.Domain.Entities.Catalog;

namespace HelpDesk.Architecture.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}