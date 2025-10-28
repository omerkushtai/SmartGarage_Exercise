using System;

namespace SmartGarage_Exercise;

public abstract class FuelVehicle : Vehicle
{

    public int FuelPercentage { get;  protected set; }
    public FuelVehicle(string model, int fuel) : base (model)
    {
        FuelPercentage = Math.Clamp(fuel, 0, 100);
    }
     public virtual void Refuel()
	{
		FuelPercentage = 100;
	}
}
