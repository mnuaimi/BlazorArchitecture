using HelpDesk.Architecture.Application.Interfaces.Repositories;
using HelpDesk.Architecture.Domain.Entities.Catalog;

namespace HelpDesk.Architecture.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}