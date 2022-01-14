using Budget_Tracker_Persistence.Models;

namespace Budget_Tracker_Persistence.Repositories
{
    public interface IAccountRepository
    {
        public Task<int> AddAccount(Account account);
        public Task<IEnumerable<Account>> GetAccounts();
    }
}
