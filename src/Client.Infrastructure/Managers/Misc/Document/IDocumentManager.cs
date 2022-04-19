using HelpDesk.Architecture.Application.Features.Documents.Commands.AddEdit;
using HelpDesk.Architecture.Application.Features.Documents.Queries.GetAll;
using HelpDesk.Architecture.Application.Requests.Documents;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Features.Documents.Queries.GetById;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}