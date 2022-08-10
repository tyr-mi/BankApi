using Bank.DAL.Models;
using Bank.Models.Transactions;

namespace Bank.DAL.Repositories;

public interface ITransactionRepository
{
    IEnumerable<Transaction> GetAllTransactions();
    SPResult CreateTransaction(CreateTransactionDto transaction);
    SPResult DeleteTransaction(DeleteTransactionDto deleteTransactionDto);
    SPResult UpdateTransaction(UpdateTransactionDto updateTransactionDto);
}