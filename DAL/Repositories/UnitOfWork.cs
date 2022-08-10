using System.Data;
using Bank.DAL.DBContexts;

namespace Bank.DAL.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IDbConnection _connection;
    private IDbTransaction _transaction;
    private Guid _id;

    public UnitOfWork(IDapperContext context)
    {
        _id = new Guid();
        _connection = context.CreateConnection();
    }
    
    Guid IUnitOfWork.Id => _id;
    IDbConnection IUnitOfWork.Connection => _connection;
    IDbTransaction IUnitOfWork.Transaction => _transaction;
    
    public void Dispose()
    {
        if (_transaction != null)
        {
            _transaction.Dispose();
        }

        _transaction = null;
    }
    
    public void Begin()
    {
        if ((_connection.State & ConnectionState.Open) == 0)
        {
            _connection.Open();
        }
        _transaction = _connection.BeginTransaction();
    }

    public void Commit()
    {
        _transaction.Commit();
        Dispose();
    }

    public void Rollback()
    {
        _transaction.Rollback();
        Dispose();
    }
}