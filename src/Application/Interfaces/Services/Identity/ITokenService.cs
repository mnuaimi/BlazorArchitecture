using HelpDesk.Architecture.Application.Interfaces.Common;
using HelpDesk.Architecture.Application.Requests.Identity;
using HelpDesk.Architecture.Application.Responses.Identity;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Threading.Tasks;

namespace HelpDesk.Architecture.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}