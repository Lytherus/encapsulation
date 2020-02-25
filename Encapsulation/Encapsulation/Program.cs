using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.EngineSize = 6.2;
            Console.WriteLine(car.EngineSize);
            car.Name = "Subaru";
            Console.WriteLine(car.Name);
            car.Year = 2003;
            Console.WriteLine(car.Year);
        }
    }
}
