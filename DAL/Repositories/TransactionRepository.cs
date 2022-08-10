using System.Data;
using Bank.DAL.Models;
using Bank.Models.Transactions;
using Dapper;
using Mapster;

namespace Bank.DAL.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private IUnitOfWork _unitOfWork;
    
    public TransactionRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public IEnumerable<Transaction> GetAllTransactions()
    {
        var query = "SELECT * FROM [Transaction]";
        var res = _unitOfWork.Connection.Query<Transaction>(query);
        return res;
    }

    public SPResult CreateTransaction(CreateTransactionDto transaction)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("AddTransaction", transaction, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult{RowCount = spResult};
    }

    public SPResult DeleteTransaction(DeleteTransactionDto deleteTransactionDto)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("DeleteTransaction", deleteTransactionDto, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult { RowCount = spResult};
    }

    public SPResult UpdateTransaction(UpdateTransactionDto updateTransactionDto)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("UpdateTransaction", updateTransactionDto, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult { RowCount = spResult};
    }
}