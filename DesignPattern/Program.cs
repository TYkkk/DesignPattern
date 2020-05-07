using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory carFactory = new CarFactory();
            Factory planeFactory = new PlaneFactory();

            Vehicles car = carFactory.CreateVehicles();
            Vehicles plane = planeFactory.CreateVehicles();

            car.Use();
            plane.Use();

            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
