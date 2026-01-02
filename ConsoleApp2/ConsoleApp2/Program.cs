using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{ 
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Speed: " + Speed + " km/h");
        }
    }
    class Car : Vehicle
    {
        public string FuelType { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Fuel Type: " + FuelType);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Brand = "supur*";
            myCar.Speed = 250;
            myCar.FuelType = "abc";
            myCar.DisplayInfo();

            Console.ReadLine();
        }
    }
}
