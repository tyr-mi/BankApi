using Bank.DAL.Models;
using Bank.Models.Accounts;
using Bank.Models.Transactions;
using Models.Clients;

namespace Bank.Services;

public interface IAccountService
{
    IEnumerable<ClientDto> GetAllClients();
    ClientDto GetClientById(GetClientDto getClientDto);
    SPResult CreateClient(CreateClientDto createClientDto);
    SPResult DeleteClient(DeleteClientDto deleteClientDto);
    SPResult UpdateClient(UpdateClientDto updateClientDto);
    IEnumerable<AccountDto> GetAllAccounts();
    AccountDto GetAccountById(GetAccountDto getAccountDto);
    SPResult CreateAccount(CreateAccountDto createAccountDto);
    SPResult DeleteAccount(DeleteAccountDto deleteAccountDto);
    SPResult UpdateAccount(UpdateAccountDto updateAccountDto);
    AccountBalanceDto GetAccountBalance(GetAccountDto getAccountDto);
}