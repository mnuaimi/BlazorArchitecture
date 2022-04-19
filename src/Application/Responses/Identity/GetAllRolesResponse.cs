using System.Collections.Generic;

namespace HelpDesk.Architecture.Application.Responses.Identity
{
    public class GetAllRolesResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}