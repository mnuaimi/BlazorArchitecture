using HelpDesk.Architecture.Shared.Wrapper;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Features.Dashboards.Queries.GetData;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}