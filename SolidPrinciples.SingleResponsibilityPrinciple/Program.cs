using SolidPrinciples.SingleResponsibilityPrinciple;

namespace SolidPriciples.SingleResponsibilityPrinciple;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "SRP - Single Responsibility Principle Örneği";

        Console.WriteLine("=======================================");
        Console.WriteLine("  Single Responsibility Principle");
        Console.WriteLine("=======================================\n");

        string reportName = "Aylık Satış Raporu";

        var generator = new ReportGenerator();
        var saver = new ReportSaver();

        generator.GenerateReport(reportName);
        saver.SaveReport(reportName);

        Console.WriteLine("\nHer sınıf yalnızca tek bir sorumluluğa sahiptir:");
        Console.WriteLine(" - ReportGenerator: Rapor üretir");
        Console.WriteLine(" - ReportSaver: Raporu kaydeder");

        Console.WriteLine("\nProgram başarıyla tamamlandı.");
        Console.ReadKey();
    }
}