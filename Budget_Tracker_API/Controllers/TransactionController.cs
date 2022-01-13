using Budget_Tracker_Services.Services;
using Microsoft.AspNetCore.Http;
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
        public IEnumerable<Budget_Tracker_Services.Models.Transaction_Model> GetAll()
        {
            return _transactionService.GetTransactions();
        }

        [HttpGet("{id}", Name = "SingleTransaction")]
        public Budget_Tracker_Services.Models.Transaction_Model Get(int id)
        {
            return _transactionService.GetTransaction(id);
        }

        [HttpDelete("{id}", Name ="DeleteTransaction")]
        public IActionResult Delete(int id)
        {
            _transactionService.DeleteTransaction(id);
            return Ok();
        }

        [HttpPut("{id}", Name = "UpdateTransaction")]
        public IActionResult Update(Budget_Tracker_Services.Models.Transaction_Model transaction)
        {
            _transactionService.UpdateTransaction(transaction);
            return Ok();
        }
    }
}
