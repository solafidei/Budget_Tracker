using Budget_Tracker_Services.Models;

namespace Budget_Tracker_Services.Services
{
    public interface ITransactionService
    {
        public Task<IEnumerable<Transaction_Model>> GetTransactions();
        public Task<Transaction_Model> GetTransaction(int id);
        public Task<int> DeleteTransaction(int id);
        public Task<int> UpdateTransaction(Transaction_Model transaction);
        public Task<int> AddTransaction(Transaction_Model transaction);
    }
}
