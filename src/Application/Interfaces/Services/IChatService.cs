using HelpDesk.Architecture.Application.Responses.Identity;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Interfaces.Chat;
using HelpDesk.Architecture.Application.Models.Chat;

namespace HelpDesk.Architecture.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}