using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Online_Shop.Data;
using Online_Shop.Dtos.Product;
using Online_Shop.Models;

namespace Online_Shop.Repositories.ProductRepositoory
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Response<GetProductDto>> CreateAsync(AddProductDto newProduct)
        {
            var response = new Response<GetProductDto>();
            var product = _mapper.Map<Product>(newProduct);

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            response.Message = "Product added successfully";
            response.Data = _mapper.Map<GetProductDto>(product);
            return response;
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(result => result.Id == id);

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }


        public async Task<Response<IEnumerable<GetProductDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<GetProductDto>>();
            var products = await _context.Products.Select(product => _mapper.Map<GetProductDto>(product)).ToListAsync();

            response.Data = products;
            return response;
        }

        public async Task<Response<GetProductDto>> GetByIdAsync(int id)
        {
            var response = new Response<GetProductDto>();
            var product = await _context.Products.FirstOrDefaultAsync(result => result.Id == id);

            response.Data = _mapper.Map<GetProductDto>(product);
            return response;
        }

        public async Task UpdateAsync(UpdateProductDto productChanges)
        {

            var productToUpdate = _mapper.Map<Product>(productChanges);
            var product = _context.Products.Attach(productToUpdate);
            product.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ProductExists(int id)
        {
            return await _context.Products.AnyAsync(p => p.Id == id);
        }
    }
}
