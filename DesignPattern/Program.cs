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

            Builder highBuilder = new HighConfigComputerBuilder();
            Builder lowBuilder = new LowConfigComputerBuilder();
            Director director = new Director();

            director.Construct(highBuilder);
            highBuilder.GetComputer().Show();

            director.Construct(lowBuilder);
            lowBuilder.GetComputer().Show();

            TestData02 t2 = new TestData02();
            t2.ID = 2;
            t2.Data = new System.Collections.Generic.List<int>();
            t2.Data.Add(1);
            t2.Data.Add(2);

            TestData02 t2copy = (TestData02)t2.Copy();
            t2copy.ID = 3;
            t2copy.Data.Clear();

            Console.WriteLine($"{t2.ID}/{t2.Data.Count}");
            Console.WriteLine($"{t2copy.ID}/{t2copy.Data.Count}");

            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
