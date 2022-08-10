namespace Bank.DAL.Models;

public class Account
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public long AccountType { get; set; }
    public long Remaining { get; set; }
}