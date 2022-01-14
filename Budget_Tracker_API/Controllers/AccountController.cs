using Budget_Tracker_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Budget_Tracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost(Name = "AddAccount")]
        public async Task<IActionResult> Add(Budget_Tracker_Services.Models.Account_Model account)
        {
            return Ok(await _accountService.AddAccount(account));
        }

        [HttpGet(Name = "AllAccounts")]
        public async Task<ActionResult<IEnumerable<Budget_Tracker_Services.Models.Account_Model>>> GetAll()
        {
            return Ok(await _accountService.GetAccounts());
        }
    }
}
