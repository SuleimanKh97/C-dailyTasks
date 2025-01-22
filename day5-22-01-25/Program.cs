using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_22_01_25
{
     class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Start() 
        {
            Console.WriteLine("Vehicle is starting.");
        }


    }

    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            Car car = new Car();
            car.Brand = "BMW";
            car.Model = "M5";
            car.NumberOfDoors = 2;
            car.Start();
            Console.WriteLine($"the Car is {car.Brand} and the Model is {car.Model} and The Number of Doors is {car.NumberOfDoors}");
        }
    }


}
// What is constructor ? constructor is a special method that is called when an instance of a class is created. It has the same name as the class and no return type.

// What are the basic concepts of OOPs ? Encapsulation; Abstraction; Polymorphism; Inheritance.

// What is the Encapsulation ? Encapsulation is the bundling of data with the methods that operate on that data, or the restricting of direct access to some of an object's components.

// What is the Inheritance concept ? Inheritance is a mechanism in which one class acquires the property of another class.

// What is the sealed class ? A sealed class is a class that cannot be inherited.