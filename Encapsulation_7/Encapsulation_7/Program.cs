using System;
public class Bank
{
    private double balance;
    private int id;
    public string name,address;
    public Bank(string name,string address,int id,double balance)
    {
        this.name = name;
        this.address = address;
        this.id = id;
        this.balance = balance;
    }
    public void Details()
    {
        Console.WriteLine("\n\n\n========== Islami Bank Limited ==========");
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Sorry, you have leass amount.\n");
        }
    }
    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Display()
    {
        Details();
        Console.WriteLine("Name    : " + this.name);
        Console.WriteLine("Address : " + this.address);
        Console.WriteLine("ID      : " + this.id);
        Console.WriteLine("Balance : {0}tk",balance);

    }

    public double GetBalance() { return balance; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------- Welcome to the Bank -----------");
        Console.WriteLine("Please give your correct information - ");
        string name, address;
        int id, press;
        double balance, amount;

        Console.Write("1. Your Name    : ");
        name = Convert.ToString(Console.ReadLine());
        Console.Write("2. Your Address : ");
        address = Convert.ToString(Console.ReadLine());
        Console.Write("3. Account ID   : ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("4. Your balance : ");
        balance = Convert.ToDouble(Console.ReadLine());

        Bank bank = new Bank(name, address, id, balance);
        bank.Display();

        Console.WriteLine("\n\n-------------------------------------------------\nPress button : ");
        Console.WriteLine("Press 1:  Withdrwal        Press 2:  Debit Balance");
        Console.WriteLine("Press 3:  Log out ");
        Console.Write("\nPress : ");
        press = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-------------------------------------------------\n");

        if (press == 1)
        {
            Console.WriteLine("-> WithDrawn <-");
            Console.WriteLine("-> Your Balance is : {0}tk" , balance);
            Console.Write("How much money do you want to withdraw ? ");
            amount = Convert.ToDouble(Console.ReadLine());
            bank.Withdraw(amount);
            Console.WriteLine("-> Your Balance is : {0}tk",bank.GetBalance());
        }
        else if (press == 2)
        {
            Console.WriteLine("-> Debit Balance <-");
            Console.WriteLine("-> Your Balance is : {0}tk" , balance);
            Console.Write("How much money do you want to Add ? ");
            amount = Convert.ToDouble(Console.ReadLine());
            bank.Deposit(amount);
            Console.WriteLine("-> Your Balance is : {0}tk" , bank.GetBalance());

        }
        else if (press == 3)
        {
            Console.WriteLine("...... Log out done successfully......\n");
        }
        else
        {
            Console.WriteLine("!!....Invalid input");
        }
    }
}