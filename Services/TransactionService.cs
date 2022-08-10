using Bank.DAL.Models;
using Bank.DAL.Repositories;
using Bank.Models.Transactions;
using Mapster;

namespace Bank.Services;

public class TransactionService : ITransactionService
{

    private readonly ITransactionRepository _repository;

    public TransactionService(ITransactionRepository repository)
    {
        _repository = repository;
    }
    
    public IEnumerable<TransactionDto> GetAllTransactions()
    {
        var transactions = _repository.GetAllTransactions();
        return transactions.Adapt<IEnumerable<TransactionDto>>();
    }
    
    public SPResult CreateTransaction(CreateTransactionDto createTransactionDto)
    {
        return _repository.CreateTransaction(createTransactionDto);
    }

    public SPResult DeleteTransaction(DeleteTransactionDto deleteTransactionDto)
    {
        return _repository.DeleteTransaction(deleteTransactionDto);
    }

    public SPResult UpdateTransaction(UpdateTransactionDto updateTransactionDto)
    {
        return _repository.UpdateTransaction(updateTransactionDto);
    }
}