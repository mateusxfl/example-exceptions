using ExampleException.Entities;
using ExampleException.Entities.Exceptions;

try
{
    Console.Clear();

    Console.WriteLine("Enter account data: \n");

    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account a = new Account(number, holder, initialBalance, withdrawLimit);


    // ----------------------------------------------------------- Withdraw

    Console.Clear();

    Console.WriteLine("Enter amount for withdraw: ");
    double amountForWithdraw = double.Parse(Console.ReadLine());

    a.Withdraw(amountForWithdraw);
}
catch (WithdrawException e)
{
    Console.WriteLine("\nWithdraw error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("\nGeneric error: " + e.Message);
}
finally
{
    Console.WriteLine("\nExecutes regardless of whether or not an exception occurs.\n");
}