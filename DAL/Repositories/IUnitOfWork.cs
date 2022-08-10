using System.Data;

namespace Bank.DAL.Repositories;

public interface IUnitOfWork : IDisposable
{
    Guid Id { get; }
    IDbConnection Connection { get; }
    IDbTransaction Transaction { get; }
    void Begin();
    void Commit();
    void Rollback();
}