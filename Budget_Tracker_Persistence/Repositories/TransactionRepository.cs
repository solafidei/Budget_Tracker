using Budget_Tracker_Persistence.Data;
using Budget_Tracker_Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget_Tracker_Persistence.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private Budget_TrackerContext _dbContext;
        public TransactionRepository(Budget_TrackerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> DeleteTransaction(int id)
        {
            _dbContext.Transaction.Remove(_dbContext.Transaction.Find(id));
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Transaction> GetTransaction(int id)
        {
            return await _dbContext.Transaction.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
            return await _dbContext.Transaction.ToListAsync();
        }

        public Task<int> UpdateTransaction(Transaction transaction)
        {
            _dbContext.Transaction.Update(transaction);
            return _dbContext.SaveChangesAsync();
        }

        public async Task<int> AddTransaction(Transaction transaction)
        {
            _dbContext.Transaction.Add(transaction);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
