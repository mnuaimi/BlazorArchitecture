using HelpDesk.Architecture.Application.Features.Products.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.Products.Queries.GetAllPaged;
using HelpDesk.Architecture.Application.Requests.Catalog;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Threading.Tasks;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}