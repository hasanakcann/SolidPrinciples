using SolidPrinciples.LiskovSubstitutionPrinciple.Birds;
using SolidPrinciples.LiskovSubstitutionPrinciple.Interfaces;

namespace SolidPrinciples.LiskovSubstitutionPrinciple;

public class Program
{
    public static void MakeBirdFly(IFlyingBird flyingBird)
    {
        flyingBird.Fly();
    }

    public static void Main(string[] args)
    {
        Console.Title = "LSP - Liskov Substitution Principle Örneği";

        Console.WriteLine("=======================================");
        Console.WriteLine("  Liskov Substitution Principle");
        Console.WriteLine("=======================================\n");

        var eagle = new Eagle();
        MakeBirdFly(eagle); 

        var ostrich = new Ostrich();
        ostrich.RunFast(); 

        Console.WriteLine("\nEagle, IFlyingBird olduğu için uçabilir.");
        Console.WriteLine("Ostrich uçma arayüzüne sahip değildir; bu sayede LSP ihlali olmaz.");

        Console.WriteLine("\nProgram başarıyla tamamlandı.");
        Console.ReadKey();
    }
}