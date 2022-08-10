namespace Bank.Models.Transactions;

public class CreateTransactionDto
{
    public long Type { get; set; }
    public long Amount { get; set; }
    public long Date { get; set; }
    public long AccountId { get; set; }
}