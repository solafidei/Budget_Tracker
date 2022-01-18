using Budget_Tracker_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Budget_Tracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private IBankService _bankService;
        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet(Name = "AllBanks")]
        public async Task<ActionResult<IEnumerable<Budget_Tracker_Services.Models.Bank_Model>>> GetAll()
        {
            return Ok(await _bankService.GetBanks());
        }

    }
}
