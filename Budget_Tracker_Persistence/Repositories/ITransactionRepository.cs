using Budget_Tracker_Persistence.Models;

namespace Budget_Tracker_Persistence.Repositories
{
    public interface ITransactionRepository
    {
        public Task<IEnumerable<Transaction>> GetTransactionsByAccount(int accountID);
        public Task<Transaction> GetTransaction(int id);
        public Task<int> DeleteTransaction(int id);
        public Task<int> UpdateTransaction(Transaction transaction);
        public Task<int> AddTransaction(Transaction transaction);
    }
}
