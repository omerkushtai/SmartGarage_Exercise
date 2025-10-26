using System;

namespace SmartGarage_Exercise;

public abstract class Vehicle: Imoveable
{
    public String ModelName { get; set; }
    public int FuelPercentage { get; set; }
    public Vehicle(string model, int fuel)
    {
        ModelName = model;
        FuelPercentage = Math.Clamp(fuel, 0, 100);
    }
    public void MoveLeft()
    {

    }
    public void MoveRight()
    {

    }
    public abstract void  Drive();
    public void Refuel();

}
