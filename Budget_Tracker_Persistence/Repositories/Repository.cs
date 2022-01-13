using Budget_Tracker_Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Budget_Tracker_Persistence.Data;
using Microsoft.Extensions.Options;

namespace Budget_Tracker_Persistence.Repositories
{
    public class Repository : IRepository
    {
        private Budget_TrackerContext dbContext;
        public Repository(Budget_TrackerContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task DeleteTransaction(int id)
        {
            dbContext.Transaction.Remove(dbContext.Transaction.Find(id));
            return Task.CompletedTask;
        }

        public Transaction GetTransaction(int id)
        {
            return dbContext.Transaction.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return dbContext.Transaction.ToList();
        }

        public Task UpdateTransaction(Transaction transaction)
        {
            dbContext.Transaction.Update(transaction);
            return Task.CompletedTask;
        }
    }
}
