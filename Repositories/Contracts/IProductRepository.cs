using Entities.Models;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProduct(bool trackChanges);
        IQueryable<Product> GetShowCaseProduct(bool trackChanges);

        Product? GetOneProduct(int id, bool trackChanges);

        void CreateOneProduct(Product product);
        void DeleteOneProduct(Product product);
        void UpdateOneProduct(Product entity);
    }
}

