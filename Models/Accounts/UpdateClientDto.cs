namespace Bank.Models.Accounts;

public class UpdateClientDto
{
    public long Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public string phone { get; set; }
    public long Age { get; set; }
}