using AutoMapper;
using Budget_Tracker_Persistence.Repositories;
using Budget_Tracker_Services.Models;

namespace Budget_Tracker_Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Product_Model>> GetBankProducts(int bankID)
        {
            return _mapper.Map<IEnumerable<Product_Model>>(await _repository.GetBankProducts(bankID));
        }
    }
}
