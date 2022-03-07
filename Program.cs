using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Isabele", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWhitdrawal(120,DateTime.Now,"Hammock"); 

            account.MakeWhitdrawal(50,DateTime.Now,"Xbox Game");

            Console.WriteLine(account.GetAccountHistory());
            
            
            
            
            
            
            
            
            // Test that the initial balances must be positive.
            // BankAccount invalidAccount;
            // try
            // {
            //     invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(e.ToString());
            //     return;
            // }

            
        }
    }
}
