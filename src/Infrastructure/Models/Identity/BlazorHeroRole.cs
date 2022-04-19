using System;
using System.Collections.Generic;
using HelpDesk.Architecture.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace HelpDesk.Architecture.Infrastructure.Models.Identity
{
    public class HelpDeskRole : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual ICollection<HelpDeskRoleClaim> RoleClaims { get; set; }

        public HelpDeskRole() : base()
        {
            RoleClaims = new HashSet<HelpDeskRoleClaim>();
        }

        public HelpDeskRole(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<HelpDeskRoleClaim>();
            Description = roleDescription;
        }
    }
}