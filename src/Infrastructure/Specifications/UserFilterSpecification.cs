using HelpDesk.Architecture.Infrastructure.Models.Identity;
using HelpDesk.Architecture.Application.Specifications.Base;

namespace HelpDesk.Architecture.Infrastructure.Specifications
{
    public class UserFilterSpecification : HeroSpecification<HelpDeskUser>
    {
        public UserFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.FirstName.Contains(searchString) || p.LastName.Contains(searchString) || p.Email.Contains(searchString) || p.PhoneNumber.Contains(searchString) || p.UserName.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}