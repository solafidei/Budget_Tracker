using Budget_Tracker_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker_Services.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<Product_Model>> GetBankProducts(int bankID);
    }
}
