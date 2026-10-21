using System;

namespace VehicleConfigurationSystem
{
    abstract class Vehicle
    {

        public string FuelType { get; set; }
        public int Capacity { get; set; }
        public abstract void Start();
        public abstract void Engine();
        public void ShowDetails()
        {
            Console.WriteLine($"Fuel Type : {FuelType}");
            Console.WriteLine($"Capacity : {Capacity} Passengers");
        }
    }

    class Car : Vehicle
    {
        public override void Engine()
        {
            Console.WriteLine("Car is starting with key ignition");
        }

        public override void Start()
        {
            Console.WriteLine("Car is having 4-cylinder petrol Engine");
        }
    }

    class Bike : Vehicle
    {
        public override void Engine()
        {
            Console.WriteLine("Bike is starting with key ignition");
        }

        public override void Start()
        {
            Console.WriteLine("Bike is having single-cylinder petrol Engine");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Vehicle car = new Car();
            car.Start();
            car.Engine();
            car.FuelType = "Petrol";
            car.Capacity = 5;
            car.ShowDetails();

            Console.WriteLine("...................");

            Vehicle bike = new Bike();
            bike.Start();
            bike.Engine();
            bike.FuelType = "Petrol";
            bike.Capacity = 2;
            bike.ShowDetails();
        }
    }
}