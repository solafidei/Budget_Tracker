using AutoMapper;
using Budget_Tracker_Persistence.Repositories;
using Budget_Tracker_Services.Models;

namespace Budget_Tracker_Services.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _repository;
        private IMapper _mapper;
        public AccountService(IAccountRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> AddAccount(Account_Model account)
        {
            var mappedObject = _mapper.Map<Budget_Tracker_Persistence.Models.Account>(account);
            return await _repository.AddAccount(mappedObject);
        }

        public async Task<IEnumerable<Account_Model>> GetAccounts()
        {
            return _mapper.Map<IEnumerable<Account_Model>>(await _repository.GetAccounts());
        }


    }
}
