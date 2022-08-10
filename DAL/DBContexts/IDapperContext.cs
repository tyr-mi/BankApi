using System.Data;

namespace Bank.DAL.DBContexts;

public interface IDapperContext
{
    IDbConnection CreateConnection();
}