using Budget_Tracker_Services.Models;

namespace Budget_Tracker_Services.Services
{
    public interface IAccountService
    {
        public Task<int> AddAccount(Account_Model account);
        public Task<IEnumerable<Account_Model>> GetAccounts();
    }
}
