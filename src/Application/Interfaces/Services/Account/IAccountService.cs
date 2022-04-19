using HelpDesk.Architecture.Application.Interfaces.Common;
using HelpDesk.Architecture.Application.Requests.Identity;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Threading.Tasks;

namespace HelpDesk.Architecture.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}