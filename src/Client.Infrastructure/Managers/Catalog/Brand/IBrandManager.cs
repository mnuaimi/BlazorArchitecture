using HelpDesk.Architecture.Application.Features.Brands.Queries.GetAll;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Features.Brands.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.Brands.Commands.Import;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");

        Task<IResult<int>> ImportAsync(ImportBrandsCommand request);
    }
}