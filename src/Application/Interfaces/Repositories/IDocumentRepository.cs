using System.Threading.Tasks;

namespace HelpDesk.Architecture.Application.Interfaces.Repositories
{
    public interface IDocumentRepository
    {
        Task<bool> IsDocumentTypeUsed(int documentTypeId);

        Task<bool> IsDocumentExtendedAttributeUsed(int documentExtendedAttributeId);
    }
}