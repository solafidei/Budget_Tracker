using Budget_Tracker_Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace Budget_Tracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet(Name = "AllTransaction")]
        public async Task<ActionResult<IEnumerable<Budget_Tracker_Services.Models.Transaction_Model>>> GetAll()
        {
            return Ok(await _transactionService.GetTransactions());
        }

        [HttpGet("{id}", Name = "SingleTransaction")]
        public async Task<ActionResult<Budget_Tracker_Services.Models.Transaction_Model>> Get(int id)
        {
            return  Ok(await _transactionService.GetTransaction(id));
        }

        [HttpDelete("{id}", Name ="DeleteTransaction")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _transactionService.DeleteTransaction(id) > 0)
                return Ok();
            else
                return StatusCode(StatusCodes.Status304NotModified);
        }

        [HttpPut("{id}", Name = "UpdateTransaction")]
        public async Task<IActionResult> Update(Budget_Tracker_Services.Models.Transaction_Model transaction)
        {
            if (await _transactionService.UpdateTransaction(transaction) > 0)
                return Ok();
            else
                return StatusCode(StatusCodes.Status304NotModified);
        }


        [HttpPost(Name = "AddTransaction")]
        public async Task<IActionResult> Add(Budget_Tracker_Services.Models.Transaction_Model transaction)
        {
            return Ok(await _transactionService.AddTransaction(transaction));
        }
    }
}
