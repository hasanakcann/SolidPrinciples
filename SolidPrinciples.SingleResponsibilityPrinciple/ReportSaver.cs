namespace SolidPrinciples.SingleResponsibilityPrinciple;

public class ReportSaver
{
    public void SaveReport(string reportType)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Rapor Kaydedildi: \"{reportType}\"");
        Console.ResetColor();
    }
}
