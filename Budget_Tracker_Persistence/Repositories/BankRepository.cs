using Budget_Tracker_Persistence.Data;
using Budget_Tracker_Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker_Persistence.Repositories
{
    public class BankRepository : IBankRepository
    {
        private Budget_TrackerContext _dbContext;
        public BankRepository(Budget_TrackerContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Bank>> GetBanks()
        {
            return await _dbContext.Bank.ToListAsync();
        }
    }
}
