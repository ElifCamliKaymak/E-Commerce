using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;

        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _manager.ProductRepository.GetAllProduct(trackChanges).ToList();
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product = _manager.ProductRepository.GetOneProduct(id, trackChanges);

            if (product is null)
                throw new Exception("Product not found!");
                
            return product;
        }


    }
}