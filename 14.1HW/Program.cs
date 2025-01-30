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

}