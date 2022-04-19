using System.Collections.Generic;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Interfaces.Common;
using HelpDesk.Architecture.Application.Requests.Identity;
using HelpDesk.Architecture.Application.Responses.Identity;
using HelpDesk.Architecture.Shared.Wrapper;

namespace HelpDesk.Architecture.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}