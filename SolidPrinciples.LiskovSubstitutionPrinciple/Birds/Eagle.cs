using SolidPrinciples.LiskovSubstitutionPrinciple.Base;
using SolidPrinciples.LiskovSubstitutionPrinciple.Interfaces;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.Birds;

public class Eagle : Bird, IFlyingBird
{
    public void Fly()
    {
        Console.WriteLine("Kartal güçlü kanatlarıyla süzülüyor.");
    }
}
