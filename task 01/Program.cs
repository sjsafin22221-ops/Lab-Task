using System;

namespace VehicleManagementSystem
{
   
    class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Runtime");
        }
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Runtime 01");
        }

        public sealed override void Start()
        {
            Console.WriteLine("Car has started");
        }
    }
    class Bike : Vehicle
    {
        
        public override void Start()
        {
            Console.WriteLine("Bike has started");
        }
    }

    class Truck : Vehicle
    {

        public new void Start()
        {
            Console.WriteLine("Truck has started");
        }
        
    }


    class SportsCar : Car
    {
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            
           // Vehicle vehicle;

            Car vehicle = new Car();
            vehicle.Start();   

            Vehicle vehicle1 = new Bike();

            Bike vehicle2 = new Bike();

            vehicle1.Start();  

            Console.WriteLine();

            
            Vehicle v = new Truck();
            v.Start();   
            Truck t = new Truck();
            t.Start();   

            Console.WriteLine();

            SportsCar sportsCar = new SportsCar();

            sportsCar.Start();

            Console.WriteLine();
            Console.WriteLine("Attempting to override Start() in SportsCar");
            Console.WriteLine("will generate a compiler error because");
            Console.WriteLine("Car.Start() is declared as sealed override.");

            Console.ReadKey();
        }
    }
}