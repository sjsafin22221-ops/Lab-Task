using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VehicleManagementSystem
{

    class Vehicle
    {

        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }


    class Car : Vehicle
    {

        public sealed override void Start()
        {
            Console.WriteLine("Car starts with a key or push button.");
        }
    }


    class Bike : Vehicle
    {

        public override void Start()
        {
            Console.WriteLine("Bike starts with a self-start or kick-start.");
        }
    }


    class Truck : Vehicle
    {

        public new void Start()
        {
            Console.WriteLine("Truck starts with a heavy-duty engine.");
        }
    }


    class SportsCar : Car
    {
        /*


        public override void Start()
        {
            Console.WriteLine("Sports Car starts.");
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Runtime Polymorphism =====");


            Vehicle v1;


            v1 = new Car();
            v1.Start();

            v1 = new Bike();
            v1.Start();

            Console.WriteLine();

            Console.WriteLine(" Method Hiding (new keyword)");


            Vehicle v2 = new Truck();
            v2.Start();

            Truck t = new Truck();
            t.Start();

            Console.WriteLine();

            Console.WriteLine("Sealed Override ");

            SportsCar sportsCar = new SportsCar();


            sportsCar.Start();

            Console.WriteLine();
            Console.WriteLine("Attempting to override Start() in SportsCar");


            Console.ReadKey();
        }
    }
}