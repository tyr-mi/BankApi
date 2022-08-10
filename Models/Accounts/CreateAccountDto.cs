namespace Bank.Models.Accounts;

public class CreateAccountDto
{
    public long AccountType { get; set; }
    public long Remaining { get; set; }
    public long ClientId { get; set; }
}