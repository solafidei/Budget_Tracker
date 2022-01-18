using Budget_Tracker_Persistence.Data;
using Budget_Tracker_Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget_Tracker_Persistence.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private Budget_TrackerContext _dbContext;
        public AccountRepository(Budget_TrackerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddAccount(Account account)
        {
            _dbContext.Account.Add(account);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _dbContext.Account.Include(a => a.Product).ToListAsync();
        }
    }
}
