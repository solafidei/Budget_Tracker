using AutoMapper;
using Budget_Tracker_Persistence.Repositories;
using Budget_Tracker_Services.Models;

namespace Budget_Tracker_Services.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _repository;
        private readonly IMapper _mapper;
        public BankService(IBankRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Bank_Model>> GetBanks()
        {
            return _mapper.Map<IEnumerable<Bank_Model>>(await _repository.GetBanks());
        }
    }
}
