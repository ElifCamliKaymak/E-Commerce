using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product? GetOneProduct(int id, bool trackChanges);
        void UpdateOneProduct(ProductDtoForUpdate productDto);
        void CreateProduct(ProductDtoForInsertion productDto);
        void DeleteOneProduct(int id);
        ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges);
    }
}