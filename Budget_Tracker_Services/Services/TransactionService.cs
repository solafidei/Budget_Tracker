using AutoMapper;
using Budget_Tracker_Persistence.Repositories;
using Budget_Tracker_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker_Services.Services
{
    public class TransactionService : ITransactionService
    {
        private IRepository _repository;
        private IMapper _mapper;
        public TransactionService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper= mapper;
        }
        public IEnumerable<Transaction_Model> GetTransactions()
        {
            return _mapper.Map<IEnumerable<Transaction_Model>>(_repository.GetTransactions());
        }

        public Transaction_Model GetTransaction(int id)
        {
            return _mapper.Map<Transaction_Model>(_repository.GetTransaction(id));
        }

        public Task DeleteTransaction(int id)
        {
            return _repository.DeleteTransaction(id);
        }

        public Task UpdateTransaction(Transaction_Model transaction)
        {
            var mappedObject = _mapper.Map<Budget_Tracker_Persistence.Models.Transaction>(transaction);
            return _repository.UpdateTransaction(mappedObject);
        }
    }
}
