using API.Data;
using API.Entities; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<ProductController> _logger;

        public ProductController(AppDbContext dbContext, ILogger<ProductController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            _logger.LogInformation("Request received to get all products");
            var products = await _dbContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            if (id < 1)
                return BadRequest("Id must be greater than 0");

            _logger.LogInformation("Request received to get product with Id: {id}", id);

            var product = await _dbContext.Products.FindAsync(id);
            if (product == null)
                return NotFound($"Product with Id {id} not found");

            return Ok(product);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
        {
            if (product == null)
                return BadRequest("Product data is missing");

            _logger.LogInformation("Request received to create a new product");

            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Product>> UpdateProduct(int id, [FromBody] Product product)
        {
            if (id < 1)
                return BadRequest("Id must be greater than 0");

            if (product == null || product.Id != id)
                return BadRequest("Product data is invalid or mismatched");

            _logger.LogInformation("Request received to update product with Id: {id}", id);

            var existingProduct = await _dbContext.Products.FindAsync(id);
            if (existingProduct == null)
                return NotFound($"Product with Id {id} not found");

            _dbContext.Entry(existingProduct).CurrentValues.SetValues(product);
            await _dbContext.SaveChangesAsync();

            return Ok(existingProduct);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            if (id < 1)
                return BadRequest("Id must be greater than 0");

            _logger.LogInformation("Request received to delete product with Id: {id}", id);

            var product = await _dbContext.Products.FindAsync(id);
            if (product == null)
                return NotFound($"Product with Id {id} not found");

            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
