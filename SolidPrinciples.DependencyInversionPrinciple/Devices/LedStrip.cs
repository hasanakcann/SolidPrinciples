using SolidPrinciples.DependencyInversionPrinciple.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Devices;

public class LedStrip : ILightDevice
{
    public void TurnOn()
    {
        Console.WriteLine("LED şerit açıldı.");
    }

    public void TurnOff()
    {
        Console.WriteLine("LED şerit kapandı.");
    }
}
