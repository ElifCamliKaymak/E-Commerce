using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public IQueryable<Product> GetAllProduct(bool trackChanges)
            => FindAll(trackChanges);


        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FingByCondition(p=>p.ProductId.Equals(id),trackChanges);
        }
    }
}