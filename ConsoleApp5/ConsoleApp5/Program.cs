using System;

namespace N2
{
    public class Vehicle
    {
        private int speed = 60;
        private protected string type = "Generic Vehicle";
        protected internal double acceleration;

        public virtual void Describe()
        {
            Console.WriteLine("Vehicle: Speed = " + speed);
        }

        public string GetTypeInfo()
        {
            return type;
        }
    }

    public class Car : Vehicle
    {
        public new void Describe()
        {
            Console.WriteLine("Car: unknown");
        }

        public void ShowType()
        {
            Console.WriteLine("Car Type: " + type);
        }
    }

    public class TransportDemo
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();
            //myCar.Describe();
            //myCar.ShowType();

            Vehicle vehicleRef = new Car();
            vehicleRef.Describe();
        }
    }
}
