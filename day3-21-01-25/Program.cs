using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day3_21_01_25
{

    class Student
    {
        public string studentName { get; set; } // property
        public double age { get; set; }  // property
        public int studentId { get; set; }  // property
        public string email { get; set; }  // property

        public const double minAge = 18;  // const feild
        public const double maxAge = 40;  // const feild

        public Student()  //Constructor default values
        {
            studentName = "";
            age = 0;
            studentId = 0;
        }
        public Student(string studentName, double age, int studentId)  //Constructor with parameters
        {
            this.studentName = studentName;
            this.age = age;
            this.studentId = studentId;
        }
        public void getDetails() // method for print to console student data
        {
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Age: " + age);
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("******************************************************");
        }

        ~Student()  //Destructor
        {
            Console.WriteLine("Object is destroyed");
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student(); // object we create the data manually
            student1.studentName = "ahmad";
            student1.age = 22;
            student1.studentId = 1001;
            student1.getDetails();




            Student student2 = new Student("ali", 24, 1002); //object the data is passed as parameters
            student2.getDetails();

            Student student3 = new Student("sara", 21, 1003); //object the data is passed as parameters
            student3.getDetails();





        }

        
        //1- A class is a blueprint for creating objects (a particular data structure), providing initial values for state (property or fields), and implementations of behavior (member functions or methods). The user-defined objects are created using the class keyword.
        //2- Object: An instance of a class containing specific data and behavior defined by the class.

        //3- Difference: A class is a blueprint, while an object is a specific instance of that blueprint.

        //4- OOP Principles: Encapsulation, Inheritance, Polymorphism, and Abstraction.

        //5- Property: A class member that provides a flexible way to access and modify fields, often with get and set methods.

        //6- Field: A variable defined within a class to store data and it is privet.

        //7- Constructor: A special method used to initialize objects of a class.

        //8- Encapsulation: Restricting access to an object's data and exposing only necessary parts through methods or properties.


    }
}
