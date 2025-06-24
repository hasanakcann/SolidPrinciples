using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Workers;

public class HumanWorker : IWorkable, IEatable, ISleepable
{
    public void Work()
    {
        Console.WriteLine("İnsan çalışan işini yapıyor.");
    }

    public void Eat()
    {
        Console.WriteLine("İnsan çalışan yemek yiyor.");
    }

    public void Sleep()
    {
        Console.WriteLine("İnsan çalışan uyuyor.");
    }
}
