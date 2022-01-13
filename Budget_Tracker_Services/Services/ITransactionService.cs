using Budget_Tracker_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker_Services.Services
{
    public interface ITransactionService
    {
        public IEnumerable<Transaction_Model> GetTransactions();
        public Transaction_Model GetTransaction(int id);
        public Task DeleteTransaction(int id);
        public Task UpdateTransaction(Transaction_Model transaction);
    }
}
