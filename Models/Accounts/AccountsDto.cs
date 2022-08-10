namespace Bank.Models.Accounts
{
    public class AccountDto
    {
        public long Id { get; set; }
        public long AccountType { get; set; }
        public long Remaining { get; set; }
        public long ClientId { get; set; }
    }
}