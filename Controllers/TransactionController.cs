using Microsoft.AspNetCore.Mvc;
using Bank.Models.Transactions;
using Bank.Services;

namespace Bank.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    private ITransactionService _service;

    public TransactionController(ITransactionService service)
    {
        _service = service;
    }
    
    [HttpGet("")]
    public IActionResult GetAllTransactions()
    {
        return Ok(_service.GetAllTransactions());
    }

    [HttpPost("")]
    public IActionResult CreateTransaction([FromBody] CreateTransactionDto createTransactionDto)
    {
        return Ok(_service.CreateTransaction(createTransactionDto));
    }

    [HttpDelete("{Id}")]
    public IActionResult DeleteTransaction([FromRoute] DeleteTransactionDto deleteTransactionDto)
    {
        return Ok(_service.DeleteTransaction(deleteTransactionDto));
    }

    [HttpPut("")]
    public IActionResult UpdateTransaction([FromBody] UpdateTransactionDto updateTransactionDto)
    {
        return Ok(_service.UpdateTransaction(updateTransactionDto));
    }
}


