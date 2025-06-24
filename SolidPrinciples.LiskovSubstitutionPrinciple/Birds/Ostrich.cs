using SolidPrinciples.LiskovSubstitutionPrinciple.Base;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.Birds;

public class Ostrich : Bird
{
    public void RunFast()
    {
        Console.WriteLine("Devekuşu çok hızlı koşuyor.");
    }
}
