using System.Collections.Generic;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Features.DocumentTypes.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.DocumentTypes.Queries.GetAll;
using HelpDesk.Architecture.Shared.Wrapper;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}