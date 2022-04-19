using HelpDesk.Architecture.Application.Interfaces.Repositories;
using HelpDesk.Architecture.Domain.Entities.Misc;

namespace HelpDesk.Architecture.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}