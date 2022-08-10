using Bank.DAL.Models;
using Bank.Models.Accounts;

namespace Bank.DAL.Repositories;

public interface IAccountRepository
{
    IEnumerable<Client> GetAllClients();
    Client GetClientById(GetClientDto getClientDto);
    SPResult CreateClient(CreateClientDto createClientDto);
    SPResult DeleteClient(DeleteClientDto deleteClientDto);
    SPResult UpdateClient(UpdateClientDto updateClientDto);
    IEnumerable<Account> GetAllAccounts();
    Account GetAccountById(GetAccountDto getAccountDto);
    SPResult CreateAccount(CreateAccountDto createAccountDto);
    SPResult DeleteAccount(DeleteAccountDto deleteAccountDto);
    SPResult UpdateAccount(UpdateAccountDto updateAccountDto);
}