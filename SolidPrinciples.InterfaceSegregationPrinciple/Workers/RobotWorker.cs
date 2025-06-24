using SolidPrinciples.InterfaceSegregationPrinciple.Interfaces;

namespace SolidPrinciples.InterfaceSegregationPrinciple.Workers;

public class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot çalışan işini yapıyor.");
    }
}
