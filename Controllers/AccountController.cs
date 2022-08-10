using Bank.Models.Accounts;
using Bank.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{

    private readonly IAccountService _service;
    
    public AccountController(IAccountService service)
    {
        _service = service;
    }

    [ActionName("Get all clients")]
    [HttpGet("client")]
    public IActionResult GetAllClients()
    {
        return Ok(_service.GetAllClients());
    }

    [HttpGet("client/{Id}")]
    public IActionResult GetClientById([FromRoute] GetClientDto getClientDto)
    {
        return Ok(_service.GetClientById(getClientDto));
    }

    [HttpPost("client")]
    public IActionResult CreateClient([FromBody] CreateClientDto createClientDto)
    {
        return Ok(_service.CreateClient(createClientDto));
    }

    [HttpDelete("client/{Id}")]
    public IActionResult DeleteClient([FromRoute] DeleteClientDto deleteClientDto)
    {
        return Ok(_service.DeleteClient(deleteClientDto));
    }

    [HttpPut("client")]
    public IActionResult UpdateClient([FromBody] UpdateClientDto updateClientDto)
    {
        return Ok(_service.UpdateClient(updateClientDto));
    }

    [HttpGet("account")]
    public IActionResult GetAllAccounts()
    {
        return Ok(_service.GetAllAccounts());
    }

    [HttpGet("account/{Id}")]
    public IActionResult GetAccountById([FromRoute] GetAccountDto getAccountDto)
    {
        return Ok(_service.GetAccountById(getAccountDto));
    }

    [HttpPost("account")]
    public IActionResult CreateAccount([FromBody] CreateAccountDto createAccountDto)
    {
        return Ok(_service.CreateAccount(createAccountDto));
    }

    [HttpDelete("account/{Id}")]
    public IActionResult DeleteAccount([FromRoute] DeleteAccountDto deleteAccountDto)
    {
        return Ok(_service.DeleteAccount(deleteAccountDto));
    }

    [HttpPut("account")]
    public IActionResult UpdateAccount([FromBody] UpdateAccountDto updateAccountDto)
    {
        return Ok(_service.UpdateAccount(updateAccountDto));
    }

    [HttpGet("balance/{Id}")]
    public IActionResult GetAccountBalance([FromRoute] GetAccountDto getAccountDto)
    {
        return Ok(_service.GetAccountBalance(getAccountDto));
    }
    
    
}