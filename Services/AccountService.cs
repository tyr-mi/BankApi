using System.Collections;
using Bank.DAL.Models;
using Bank.DAL.Repositories;
using Bank.Models.Accounts;
using Bank.Models.Transactions;
using Mapster;
using Models.Clients;

namespace Bank.Services;

public class AccountService : IAccountService
{

    private readonly IAccountRepository _repository;

    public AccountService(IAccountRepository repository)
    {
        _repository = repository;
    }
    
    public IEnumerable<ClientDto> GetAllClients()
    {
        var clients = _repository.GetAllClients();
        return clients.Adapt<IEnumerable<ClientDto>>();
    }

    public ClientDto GetClientById(GetClientDto getClientDto)
    {
        var client = _repository.GetClientById(getClientDto);
        return client.Adapt<ClientDto>();
    }

    public SPResult CreateClient(CreateClientDto createClientDto)
    {
        return _repository.CreateClient(createClientDto);
    }

    public SPResult DeleteClient(DeleteClientDto deleteClientDto)
    {
        return _repository.DeleteClient(deleteClientDto);
    }

    public SPResult UpdateClient(UpdateClientDto updateClientDto)
    {
        return _repository.UpdateClient(updateClientDto);
    }

    public IEnumerable<AccountDto> GetAllAccounts()
    {
        var accounts = _repository.GetAllAccounts();
        return accounts.Adapt<IEnumerable<AccountDto>>();
    }

    public AccountDto GetAccountById(GetAccountDto getAccountDto)
    {
        var account = _repository.GetAccountById(getAccountDto);
        return account.Adapt<AccountDto>();
    }

    public SPResult CreateAccount(CreateAccountDto createAccountDto)
    {
        return _repository.CreateAccount(createAccountDto);
    }

    public SPResult DeleteAccount(DeleteAccountDto deleteAccountDto)
    {
        return _repository.DeleteAccount(deleteAccountDto);
    }

    public SPResult UpdateAccount(UpdateAccountDto updateAccountDto)
    {
        return _repository.UpdateAccount(updateAccountDto);
    }
}