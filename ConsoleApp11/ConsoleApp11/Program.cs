using System;
using System.Collections.Generic;
// Payment Contract
public interface IPayment
{
    string ProviderName { get; }
    void Pay(double amount);
}
// Cash Payment
public class CashPayment : IPayment
{
    public string ProviderName
    {
        get { return "Cash Payment"; }
    }
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} taka using Cash.");
    }
}
// Card Payment
public class CardPayment : IPayment
{
    public string ProviderName
    {
        get { return "Card Payment"; }
    }
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} taka using Card.");
    }
}
// Main Program
class Program
{
    static void Main()
    {
        List<IPayment> payments = new List<IPayment>
        {
            new CashPayment(),
            new CardPayment()
        };
        foreach (IPayment payment in payments)
        {
            payment.Pay(500);
            Console.WriteLine(payment.ProviderName);
            Console.WriteLine("-------------------");
        }
        Console.ReadLine();
    }
}
