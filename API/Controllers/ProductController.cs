using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<ProductController> _logger;

        public BrandController(AppDbContext dbContext, ILogger<BrandController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Brand_DTO>>> GetAllBrands()
        {
            _logger.LogInformation("Request received to get all brands");
            return Ok(await _dbContext.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Brand_DTO>> GetBrandByID(int id)
        {
            if (id < 1)
            {
                return BadRequest("Id must be greater than 0");
            }

            _logger.LogInformation("Request received to get brand with Id: {id}", id);
            return Ok(await _dbContext.GetByIdAsync(id));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Brand_DTO>> CreateBrand([FromBody] Brand_DTO brandDto)
        {
            if (brandDto == null)
            {
                return BadRequest("Brand data is missing");
            }

            _logger.LogInformation("Request received to create a new brand");
            var createdBrand = await _dbContext.CreateAsync(brandDto);
            return CreatedAtAction(nameof(GetBrandByID), new { id = createdBrand.Id }, createdBrand);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Brand_DTO>> UpdateBrand(int id, [FromBody] Brand_DTO brandDto)
        {
            if (id < 1)
            {
                return BadRequest("Id must be greater than 0");
            }

            if (brandDto == null)
            {
                return BadRequest("Brand data is missing");
            }

            _logger.LogInformation("Request received to update brand with Id: {id}", id);
            var updatedBrand = await _dbContext.UpdateAsync(id, brandDto);

            if (updatedBrand == null)
            {
                return NotFound($"Brand with Id {id} not found");
            }

            return Ok(updatedBrand);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Brand_DTO), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteBrand(int id)
        {
            if (id < 1)
            {
                return BadRequest("Id must be greater than 0");
            }

            _logger.LogInformation("Request received to delete brand with Id: {id}", id);
            var deleted = await _dbContext.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound($"Brand with Id {id} not found");
            }

            return NoContent();
        }
    }
}
