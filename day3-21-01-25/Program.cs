using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Student(string studentName , double age , int studentId)  //Constructor
        {
            this.studentName = studentName;
            this.age = age;
            this.studentId = studentId;
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
            getDetails(student1);




            Student student2 = new Student("ali", 24, 1002); //object the data is passed as parameters
            getDetails(student2);

            Student student3 = new Student("sara", 21, 1003); //object the data is passed as parameters
            getDetails(student3);





        }

        public static void getDetails(Student student) // method for print to console student data
        {
            Console.WriteLine("Student Name: " + student.studentName);
            Console.WriteLine("Student Age: " + student.age);
            Console.WriteLine("Student ID: " + student.studentId);
            Console.WriteLine("******************************************************");
        }
    }
}
