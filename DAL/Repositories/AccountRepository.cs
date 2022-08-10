using System.Data;
using Bank.DAL.DBContexts;
using Bank.DAL.Models;
using Bank.Models.Accounts;
using Dapper;

namespace Bank.DAL.Repositories;

public class AccountRepository : IAccountRepository
{

    private readonly IUnitOfWork _unitOfWork;

    public AccountRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public IEnumerable<Client> GetAllClients()
    {
        var query = "SELECT * FROM [Client]";
        var res = _unitOfWork.Connection.Query<Client>(query);
        return res;
    }

    public Client GetClientById(GetClientDto clientDto)
    {
        var query = $"SELECT * FROM [Client] WHERE Id = {clientDto.Id}";
        var res = _unitOfWork.Connection.QuerySingle<Client>(query);
        return res;
    }

    public SPResult CreateClient(CreateClientDto createClientDto)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("AddClient", createClientDto, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult{RowCount = spResult};
    }

    public SPResult DeleteClient(DeleteClientDto deleteClientDto)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("DeleteClient", deleteClientDto, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult{RowCount = spResult};
    }

    public SPResult UpdateClient(UpdateClientDto updateClientDto)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("UpdateClient", updateClientDto, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult{RowCount = spResult};
    }

    public IEnumerable<Account> GetAllAccounts()
    {
        var query = "SELECT * FROM [Account]";
        var res = _unitOfWork.Connection.Query<Account>(query);
        return res;
    }

    public Account GetAccountById(GetAccountDto getAccountDto)
    {
        var query = $"SELECT * FROM [Account] WHERE Id = {getAccountDto.Id}";
        var res = _unitOfWork.Connection.QuerySingle<Account>(query);
        return res;
    }

    public SPResult CreateAccount(CreateAccountDto createAccountDto)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("AddAccount", createAccountDto, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult{RowCount = spResult};
    }

    public SPResult DeleteAccount(DeleteAccountDto deleteAccountDto)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("DeleteAccount", deleteAccountDto, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult{RowCount = spResult};
    }

    public SPResult UpdateAccount(UpdateAccountDto updateAccountDto)
    {
        _unitOfWork.Begin();
        var spResult = _unitOfWork.Connection.Execute("UpdateAccount", updateAccountDto, _unitOfWork.Transaction,
            commandType: CommandType.StoredProcedure);
        _unitOfWork.Commit();
        return new SPResult{RowCount = spResult};
    }
    
}