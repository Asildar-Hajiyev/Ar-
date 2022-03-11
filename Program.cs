using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qahbe Anar");
            Console.WriteLine();
            Vehicle vehicle = new Vehicle();
            vehicle.Color = "Black";
            Console.WriteLine(vehicle.Color);
            Console.WriteLine("----");
            Car car = new Car();
            car.Color = "Masinin rengi qaradir";
            Bus bus = new Bus();
            bus.GetSpeed(12,3);
            Console.WriteLine();

           
        }
    }
}
