namespace Bank.Models.Transactions;

public class UpdateTransactionDto
{
    public long Id { get; set; }
    public long Type { get; set; }
    public long Amount { get; set; }
    public long Date { get; set; }
    public long AccountId { get; set; }
}