
// 3) Print diffrent vehical details using Abstraction

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Blue", 4, "Electric", 120);
            car.Display();

            Truck truck = new Truck("Brown", 6);
            truck.Display();

            Bike bike = new Bike("matt black", 2, "Royal Enfield Bullet");
            bike.Display();

            Console.ReadKey();
        }
    }

    abstract class Vehical
    {
        public string color;
        public int tireCount;

        public Vehical(string color, int tireCount)
        {
            this.color = color;
            this.tireCount = tireCount;
        }
    }

    class Car : Vehical
    {
        string carType;
        int topSpeed;

        public Car(string color, int tireCount, string carType, int topSpeed) : base(color, tireCount)
        {
            this.carType = carType;
            this.topSpeed = topSpeed;
        }

        public void Display()
        {
            Console.WriteLine("\nThat " + color + " car is " + carType + " with a top speed of " + topSpeed + "km/hr.");
        }
    }

    class Truck : Vehical
    {
        public Truck(string color, int tireCount) : base(color, tireCount)
        {

        }

        public void Display()
        {
            Console.WriteLine("\nThat " + color + " truck has " + tireCount + " wheels.");
        }
    }

    class Bike : Vehical
    {
        string model;

        public Bike(string color, int tireCount, string model) : base(color, tireCount)
        {
            this.model = model;
        }

        public void Display()
        {
            Console.WriteLine("\nThat " + model + " looks sporty in " + color + " color.");
        }
    }

}
