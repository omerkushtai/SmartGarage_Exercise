using System;
using System.Runtime.InteropServices;

namespace SmartGarage_Exercise;

public abstract class ElectricVehicle : Vehicle, Ichargeable
{
    public int BatteryPercentage { get; protected set; }
    protected ElectricVehicle(string model, int battery) : base (model)
    {
        BatteryPercentage = 100;
    }

    public virtual void ChargeBattery()
    {
        BatteryPercentage = 100;
    }
}
