using System.Collections.Generic;

namespace HelpDesk.Architecture.Application.Responses.Identity
{
    public class GetAllUsersResponse
    {
        public IEnumerable<UserResponse> Users { get; set; }
    }
}