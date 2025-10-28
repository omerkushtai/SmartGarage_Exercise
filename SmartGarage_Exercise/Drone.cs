using System;

namespace SmartGarage_Exercise;

public class Drone : ElectricVehicle, Iverticalmoveable, Ichargeable
{
    public int velocity{get;set;}
    public int Batteryprecentage{get;private set;}
    public Drone(string model):base(model,100)
    {
        
    }
    public void Fly()
    {
        Drive();
    }

    public override void MoveLeft()
    {
         Console.WriteLine("Drone is moving right.");
    }

    public override void MoveRight()
    {
      Console.WriteLine("Drone is moving left.");
    }

    public override void Drive()
    {
        Console.WriteLine("Drone is driving/flying.");
    }

    public void MoveUp()
    {
       Console.WriteLine("Drone is moving up.");
    }

    public void MoveDown()
    {
        Console.WriteLine("Drone is moving down.");
    }
}
