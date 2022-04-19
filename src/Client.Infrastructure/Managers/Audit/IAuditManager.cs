using HelpDesk.Architecture.Application.Responses.Audit;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Audit
{
    public interface IAuditManager : IManager
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync();

        Task<IResult<string>> DownloadFileAsync(string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}