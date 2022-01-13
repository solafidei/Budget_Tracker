using Budget_Tracker_Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker_Persistence.Repositories
{
    public interface IRepository
    {
        public IEnumerable<Budget_Tracker_Persistence.Models.Transaction> GetTransactions();
        public Budget_Tracker_Persistence.Models.Transaction GetTransaction(int id);
        public Task DeleteTransaction(int id);
        public Task UpdateTransaction(Transaction transaction);
    }
}
