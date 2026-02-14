public static class BankingService
{
    public static double CheckBalance(double balance)
    {
        return balance;
    }

    public static void Deposit(ref double balance, double amount)
    {
        balance += amount;
    }

    public static void Withdraw(ref double balance, double amount, out bool success)
    {
        if (amount <= 0)
        {
            success = false;
        }
        else if (amount > balance)
        {
            success = false;
        }
        else
        {
            balance -= amount;
            success = true;
        }
    }
}
