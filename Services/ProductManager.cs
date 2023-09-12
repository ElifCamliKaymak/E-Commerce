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

        public void CreateProduct(Product product)
        {
            _manager.ProductRepository.Create(product);
            _manager.Save();
        }

        public void DeleteOneProduct(int id)
        {
            var product = GetOneProduct(id, false);
            
            if (product is not null)
            {
                _manager.ProductRepository.DeleteOneProduct(product);
                _manager.Save();
            }
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

        public void UpdateOneProduct(Product product)
        {
            var entity = _manager.ProductRepository.GetOneProduct(product.ProductId, true);
            entity.ProductName = product.ProductName;
            entity.Price = product.Price;
            _manager.Save();
        }
    }
}