using System;

namespace SmartGarage_Exercise;

public class Drone : Imoveable, Ichargeable
{
    public int Batteryprecentage{get;private set;}
    public void ChargeBattery()
    {
        Console.WriteLine("Drone battery charging.");
        Batteryprecentage = 100;
    }
    public Drone(int battery)
    {
        Batteryprecentage = Math.Clamp(battery, 0, 100);
    }
    public void Fly()
    {
        if (Batteryprecentage > 10)
        {
            Console.WriteLine("Drone cannot fly. Battery low.");
        }
        else
        {
            Console.WriteLine("Drone is flying.");
        }
    }
    public void MoveLeft()
    {
        Console.WriteLine("Drone is moving left.");
    }
    public void MoveRight()
    {
        Console.WriteLine("Drone is moving right.");
    }
}
