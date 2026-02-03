using System;

class BankAccount
{
    static void Main()
    {
        int balance = 10000;

        Console.WriteLine("Enter withdrawal amount:");
        int amount = int.Parse(Console.ReadLine()!);

        try
        {
            // TODO 1: Throw exception if amount <= 0
            if(amount<=0){
                throw new BankProblemException("Invalid Amount");
            }
            // TODO 2: Throw exception if amount > balance
            else if(amount>balance){
                throw new BankProblemException("Invalid Amount");
            }
            // TODO 3: Deduct amount if valid
            else
            {
                balance=balance-amount;
            }

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally
        {
            System.Console.WriteLine("Process Over");
        }
    }
}
public class BankProblemException : Exception
{
    public BankProblemException(string message): base(message)
    {
        
    }
}