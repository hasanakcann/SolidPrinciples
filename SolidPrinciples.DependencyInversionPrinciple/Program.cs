using SolidPrinciples.DependencyInversionPrinciple.Controllers;
using SolidPrinciples.DependencyInversionPrinciple.Devices;
using SolidPrinciples.DependencyInversionPrinciple.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "DIP - Dependency Inversion Principle Örneği";

        Console.WriteLine("=======================================");
        Console.WriteLine("  Dependency Inversion Principle");
        Console.WriteLine("=======================================\n");

        ILightDevice bulb = new LightBulb();
        var bulbSwitch = new SmartSwitch(bulb);
        bulbSwitch.Operate(true); 

        Console.WriteLine("---");

        ILightDevice led = new LedStrip();
        var ledSwitch = new SmartSwitch(led);
        ledSwitch.Operate(true);  
        ledSwitch.Operate(false); 

        Console.WriteLine("\nSmartSwitch yalnızca ILightDevice arayüzüne bağlıdır.");
        Console.WriteLine("Yeni ışık türleri eklendiğinde SmartSwitch kodu değişmeden çalışmaya devam eder.");

        Console.WriteLine("\nProgram başarıyla tamamlandı.");
        Console.ReadKey();
    }
}
