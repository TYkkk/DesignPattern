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

            PhoneFactory chinaFactory = new ChinaPhoneFactory();
            PhoneFactory americaFactory = new AmericaPhoneFactory();

            AndroidPhone chinaAndroidPhone = chinaFactory.CreateAndroidPhone();
            chinaAndroidPhone.PrintOrigin();

            americaFactory.CreateIOSPhone().PrintOrigin();

            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
