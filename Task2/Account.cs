public class Account
{
    decimal HekkiAccount = 1000;
    decimal PersonalAccount = 0;

    public void Withdraw(decimal amount)
    {
        HekkiAccount = HekkiAccount-amount;
    }

    public void AddDeposit(decimal amount)
    {
        PersonalAccount = PersonalAccount + amount;
    }

    public override string ToString()
    {
        return $"Heikki's account balance: {HekkiAccount} \nPersonal account balance: {PersonalAccount}";
    }
}