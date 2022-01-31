using System;

namespace myApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Persefoni", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            account.MakeDeposit(150, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.GetAccountHistory());

        }
    }

}