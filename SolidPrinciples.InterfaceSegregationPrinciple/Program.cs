using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;
using SolidPrinciples.InterfaceSegregationPrinciple.Workers;

namespace SolidPrinciples.InterfaceSegregationPrinciple;

public class Program
{
    public static void PerformWork(IWorkable worker)
    {
        worker.Work();
    }

    public static void ProvideFood(IEatable worker)
    {
        worker.Eat();
    }

    public static void ArrangeRest(ISleepable worker)
    {
        worker.Sleep();
    }

    public static void Main(string[] args)
    {
        Console.Title = "ISP - Interface Segregation Principle Örneği";

        Console.WriteLine("=======================================");
        Console.WriteLine("  Interface Segregation Principle");
        Console.WriteLine("=======================================\n");

        var human = new HumanWorker();
        var robot = new RobotWorker();

        PerformWork(human);
        ProvideFood(human);
        ArrangeRest(human);

        Console.WriteLine("---");

        PerformWork(robot);

        Console.WriteLine("\nRobotWorker sadece ihtiyaç duyduğu arayüzü uyguluyor.");
        Console.WriteLine("HumanWorker ise tüm fonksiyonlara sahiptir.");

        Console.WriteLine("\nProgram başarıyla tamamlandı.");
        Console.ReadKey();
    }
}
