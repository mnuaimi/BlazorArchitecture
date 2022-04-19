using System.Collections.Generic;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Requests.Identity;
using HelpDesk.Architecture.Application.Responses.Identity;
using HelpDesk.Architecture.Shared.Wrapper;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}