using AutoMapper;
using Budget_Tracker_Persistence.Repositories;
using Budget_Tracker_Services.Models;

namespace Budget_Tracker_Services.Services
{
    public class TransactionService : ITransactionService
    {
        private ITransactionRepository _repository;
        private IMapper _mapper;
        public TransactionService(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper= mapper;
        }
        public async Task<IEnumerable<Transaction_Model>> GetTransactions()
        {
            return _mapper.Map<IEnumerable<Transaction_Model>>(await _repository.GetTransactions());
        }

        public async Task<Transaction_Model> GetTransaction(int id)
        {
            return _mapper.Map<Transaction_Model>(await _repository.GetTransaction(id));
        }

        public async Task<int> DeleteTransaction(int id)
        {
            return await _repository.DeleteTransaction(id);
        }

        public async Task<int> UpdateTransaction(Transaction_Model transaction)
        {
            var mappedObject = _mapper.Map<Budget_Tracker_Persistence.Models.Transaction>(transaction);
            return await _repository.UpdateTransaction(mappedObject);
        }

        public async Task<int> AddTransaction(Transaction_Model transaction)
        {
            var mappedObject = _mapper.Map<Budget_Tracker_Persistence.Models.Transaction>(transaction);
            return await _repository.AddTransaction(mappedObject);
        }
    }
}
