using HelpDesk.Architecture.Application.Interfaces.Common;

namespace HelpDesk.Architecture.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}