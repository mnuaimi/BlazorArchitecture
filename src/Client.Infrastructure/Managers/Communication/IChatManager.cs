using HelpDesk.Architecture.Application.Models.Chat;
using HelpDesk.Architecture.Application.Responses.Identity;
using HelpDesk.Architecture.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelpDesk.Architecture.Application.Interfaces.Chat;

namespace HelpDesk.Architecture.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}