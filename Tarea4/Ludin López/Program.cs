using System;

public class BankAccount
{
    private string name;
    private int accountNumber;
    private double balance;

    public BankAccount(string name, int accountNumber, double balance)
    {
        this.name = name;
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (balance - amount >= 0)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void Display()
    {
        Console.WriteLine("Name: {0}\nAccount Number: {1}\nBalance: {2}", name, accountNumber, balance);
    }

    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount("John Doe", 123456789, 1000.00);
        account.Display();

        account.Deposit(500.00);
        account.Display();

        account.Withdraw(2000.00);
        account.Display();
    }
}