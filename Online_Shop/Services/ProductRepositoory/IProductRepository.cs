using Online_Shop.Dtos.Product;
using Online_Shop.Models;

namespace Online_Shop.Repositories.ProductRepositoory
{
    public interface IProductRepository
    {
        Task<Response<IEnumerable<GetProductDto>>> GetAllAsync();
        Task<Response<GetProductDto>> GetByIdAsync(int id);
        Task<Response<GetProductDto>> CreateAsync(AddProductDto newProduct);
        Task UpdateAsync(UpdateProductDto productChanges);
        Task DeleteAsync(int id);
        Task<bool> ProductExists(int id);
    }
}
