using System;
using HelpDesk.Architecture.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace HelpDesk.Architecture.Infrastructure.Models.Identity
{
    public class HelpDeskRoleClaim : IdentityRoleClaim<string>, IAuditableEntity<int>
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual HelpDeskRole Role { get; set; }

        public HelpDeskRoleClaim() : base()
        {
        }

        public HelpDeskRoleClaim(string roleClaimDescription = null, string roleClaimGroup = null) : base()
        {
            Description = roleClaimDescription;
            Group = roleClaimGroup;
        }
    }
}