using SolidPrinciples.DependencyInversionPrinciple.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Devices;

public class LightBulb : ILightDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Ampul açıldı.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Ampul kapandı.");
    }
}
