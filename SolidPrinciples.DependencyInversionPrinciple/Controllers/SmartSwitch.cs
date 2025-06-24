using SolidPrinciples.DependencyInversionPrinciple.Interfaces;

namespace SolidPrinciples.DependencyInversionPrinciple.Controllers;

public class SmartSwitch
{
    private readonly ILightDevice _lightDevice;

    public SmartSwitch(ILightDevice lightDevice)
    {
        _lightDevice = lightDevice;
    }

    public void Operate(bool turnOn)
    {
        if (turnOn)
            _lightDevice.TurnOn();
        else
            _lightDevice.TurnOff();
    }
}
