using SolidPrinciples.OpenClosedPrinciple.Interfaces;

namespace SolidPrinciples.OpenClosedPrinciple.Payments;

public class BitcoinPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Bitcoin ödemesi işleniyor...");
    }
}