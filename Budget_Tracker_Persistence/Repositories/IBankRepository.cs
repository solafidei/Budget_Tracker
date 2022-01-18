using Budget_Tracker_Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker_Persistence.Repositories
{
    public interface IBankRepository
    {
        public Task<IEnumerable<Bank>> GetBanks();
    }
}
