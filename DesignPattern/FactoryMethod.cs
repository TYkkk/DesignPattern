using System;

namespace DesignPattern
{
    public abstract class Vehicles
    {
        public abstract void Use();
    }

    public class Car : Vehicles
    {
        public override void Use()
        {
            Console.WriteLine("Car在地上跑");
        }
    }

    public class Plane : Vehicles
    {
        public override void Use()
        {
            Console.WriteLine("Plane在天上飞");
        }
    }

    public abstract class Factory
    {
        public abstract Vehicles CreateVehicles();
    }

    public class CarFactory : Factory
    {
        public override Vehicles CreateVehicles()
        {
            return new Car();
        }
    }

    public class PlaneFactory : Factory
    {
        public override Vehicles CreateVehicles()
        {
            return new Plane();
        }
    }
}
