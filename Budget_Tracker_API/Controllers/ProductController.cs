using Budget_Tracker_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Budget_Tracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{bankID}", Name = "BankProducts")]
        public async Task<ActionResult<IEnumerable<Budget_Tracker_Services.Models.Bank_Model>>> Get(int bankID)
        {
            return Ok(await _productService.GetBankProducts(bankID));
        }
    }
}
