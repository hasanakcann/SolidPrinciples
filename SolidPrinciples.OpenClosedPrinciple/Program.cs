using SolidPrinciples.OpenClosedPrinciple.Interfaces;
using SolidPrinciples.OpenClosedPrinciple.Payments;

namespace SolidPrinciples.OpenClosedPrinciple;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "OCP - Open/Closed Principle Örneği";

        Console.WriteLine("=======================================");
        Console.WriteLine("  Open/Closed Principle");
        Console.WriteLine("=======================================\n");

        var processor = new PaymentProcessor();

        IPaymentMethod creditCard = new CreditCardPayment();
        IPaymentMethod paypal = new PayPalPayment();
        IPaymentMethod bitcoin = new BitcoinPayment();

        processor.ProcessPayment(creditCard);
        processor.ProcessPayment(paypal);
        processor.ProcessPayment(bitcoin);

        Console.WriteLine("\nYeni ödeme yöntemleri sisteme entegre edilebilir.");
        Console.WriteLine("Var olan kod değiştirilmeden genişletilebilir.");

        Console.WriteLine("\nProgram başarıyla tamamlandı.");
        Console.ReadKey();
    }
}