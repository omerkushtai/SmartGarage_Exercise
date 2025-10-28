using System;

namespace SmartGarage_Exercise;

public abstract class Vehicle: Ihorizontalmoveable
{
    public String ModelName { get; set; }
    public int FuelPercentage { get; set; }
    public Vehicle(string model)
    {
        ModelName = model;
    }
    public abstract void MoveLeft();
    
    public abstract void MoveRight();
    
    public abstract void  Drive();
    
}
