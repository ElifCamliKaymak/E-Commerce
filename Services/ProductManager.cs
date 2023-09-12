using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ProductManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateProduct(ProductDtoForInsertion productDto)
        {
            Product product = _mapper.Map<Product>(productDto);
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

        public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
        {
            var product = GetOneProduct(id, trackChanges);
            return _mapper.Map<ProductDtoForUpdate>(product);
        }

        public void UpdateOneProduct(ProductDtoForUpdate productDto)
        {
            //var entity = _manager.ProductRepository.GetOneProduct(productDto.ProductId, true);

            /*entity.ProductName = productDto.ProductName;
            entity.Price = productDto.Price;
            entity.CategoryId = productDto.CategoryId;*/

            var entity = _mapper.Map<Product>(productDto);
            _manager.ProductRepository.UpdateOneProduct(entity);
            _manager.Save();
        }
    }
}