using System;

public class Account
{
    public string AccountName { get; set; }
    public double Balance { get; set; }

    public Account(string accountName, double initialBalance)
    {
        AccountName = accountName;
        Balance = initialBalance < 0 ? 0 : initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            Console.WriteLine("Сума депозиту має бути більше нуля");
        }
    }
    public void TakeMoney(double amount)
    {
        if (amount > 0 && Balance - amount >= 0)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Недостатньо коштів або некоректна сума зняття");
        }
    }
}

