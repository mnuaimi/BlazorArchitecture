using AutoMapper;
using HelpDesk.Architecture.Application.Features.Brands.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.Brands.Queries.GetAll;
using HelpDesk.Architecture.Application.Features.Brands.Queries.GetById;
using HelpDesk.Architecture.Domain.Entities.Catalog;

namespace HelpDesk.Architecture.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}