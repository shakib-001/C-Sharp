using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            public string Brand { get; set; }
        public int Speed { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Speed: " + Speed + " km/h");
        }
    }

    // 2. Derived class: Car (inherits Vehicle)
    class Car : Vehicle
    {
        public string FuelType { get; set; }

        // Override DisplayInfo() to include FuelType
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // call parent class method
            Console.WriteLine("Fuel Type: " + FuelType);
        }
    }

    // 3. Main method
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Car object
            Car myCar = new Car();
            myCar.Brand = "Toyota";
            myCar.Speed = 180;
            myCar.FuelType = "Petrol";

            // Display details
            myCar.DisplayInfo();

            Console.ReadLine();
        }
    }
}
}
