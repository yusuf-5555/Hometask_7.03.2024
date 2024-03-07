public class Account
{
    public decimal AccountAmount { get; set; }

    public void Balance(decimal amount)
    {
        AccountAmount = amount;
    }
    public void AddInBalance(decimal deposit)
    {
        AccountAmount = AccountAmount+deposit;
    }
    public void PrintBalance()
    {
        System.Console.WriteLine(AccountAmount);
    }
}