using HelpDesk.Architecture.Domain.Contracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HelpDesk.Architecture.Application.Interfaces.Chat;
using HelpDesk.Architecture.Application.Models.Chat;

namespace HelpDesk.Architecture.Infrastructure.Models.Identity
{
    public class HelpDeskUser : IdentityUser<string>, IChatUser, IAuditableEntity<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string CreatedBy { get; set; }

        [Column(TypeName = "text")]
        public string ProfilePictureDataUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public virtual ICollection<ChatHistory<HelpDeskUser>> ChatHistoryFromUsers { get; set; }
        public virtual ICollection<ChatHistory<HelpDeskUser>> ChatHistoryToUsers { get; set; }

        public HelpDeskUser()
        {
            ChatHistoryFromUsers = new HashSet<ChatHistory<HelpDeskUser>>();
            ChatHistoryToUsers = new HashSet<ChatHistory<HelpDeskUser>>();
        }
    }
}