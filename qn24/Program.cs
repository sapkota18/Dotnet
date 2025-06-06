using System;

// Define a delegate
public delegate void BalanceLowEventHandler(string message);

// Publisher class
class BankAccount
{
    public event BalanceLowEventHandler BalanceLow;

    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {balance}");

            if (balance < 1000)
            {
                // Raise event
                OnBalanceLow("Warning: Your account balance is low!");
            }
        }
    }

    protected virtual void OnBalanceLow(string message)
    {
        // Check if any subscribers
        if (BalanceLow != null)
        {
            BalanceLow(message);
        }
    }
}

// Subscriber class
class User
{
    public void Alert(string message)
    {
        Console.WriteLine("ALERT: " + message);
    }
}

// Main program
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(2000);
        User user = new User();

        // Subscribe to the event
        account.BalanceLow += user.Alert;

        account.Withdraw(700);
        account.Withdraw(500);  // This will trigger the event
        account.Withdraw(100);  // Event will trigger again
    }
}
