using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Dtos.Product;
using Online_Shop.Models;
using Online_Shop.Repositories.ProductRepositoory;

namespace Online_Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository) {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Response<IEnumerable<GetProductDto>>>> GetAllProducts() {
            return Ok(await _productRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Response<GetProductDto>>> GetProduct(int id) {
            if (!await _productRepository.ProductExists(id))
                return NotFound();
            return Ok(await _productRepository.GetByIdAsync(id));
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<Response<GetProductDto>>> Create(AddProductDto newProduct) {

            var result = await _productRepository.CreateAsync(newProduct);
            return CreatedAtAction(nameof(GetProduct),new { id = result.Data.Id},result);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateProduct(UpdateProductDto changedProduct) {

            if (!await _productRepository.ProductExists(changedProduct.Id))
                return NotFound();
            await _productRepository.UpdateAsync(changedProduct);
            return NoContent();
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteProduct(int id) {
            if (!await _productRepository.ProductExists(id))
                return NotFound();
            await _productRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
