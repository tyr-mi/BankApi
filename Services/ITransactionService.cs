using Bank.DAL.Models;
using Bank.Models.Transactions;

namespace Bank.Services;

public interface ITransactionService
{
    IEnumerable<TransactionDto> GetAllTransactions();
    SPResult CreateTransaction(CreateTransactionDto createTransactionDto);
    SPResult DeleteTransaction(DeleteTransactionDto deleteTransactionDto);
    SPResult UpdateTransaction(UpdateTransactionDto updateTransactionDto);

}