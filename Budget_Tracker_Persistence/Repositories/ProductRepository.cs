using Budget_Tracker_Persistence.Data;
using Budget_Tracker_Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget_Tracker_Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Budget_TrackerContext _dbContext;
        public ProductRepository(Budget_TrackerContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Product>> GetBankProducts(int bankID)
        {
            return await _dbContext.Product.Where(p => p.BankId == bankID).ToListAsync();
        }
    }
}
