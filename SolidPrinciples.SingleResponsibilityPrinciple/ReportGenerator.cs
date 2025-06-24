namespace SolidPrinciples.SingleResponsibilityPrinciple;

public class ReportGenerator
{
    public void GenerateReport(string reportType)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Rapor Oluşturuluyor: \"{reportType}\"");
        Console.ResetColor();
    }
}
