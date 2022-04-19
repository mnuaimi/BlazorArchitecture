using HelpDesk.Architecture.Application.Requests.Mail;
using System.Threading.Tasks;

namespace HelpDesk.Architecture.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}