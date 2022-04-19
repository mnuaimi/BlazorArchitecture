using System.Threading.Tasks;

namespace HelpDesk.Architecture.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}