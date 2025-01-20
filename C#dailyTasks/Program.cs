using System;

namespace ConsoleApp2
{
    internal class Program


    {




        static void Main(string[] args)
        {
            //1
            // string a = Console.ReadLine();
            //double x = Convert.ToDouble(a);
            // int y = (int) x;
            // Console.WriteLine(x);
            //  Console.WriteLine(y);
            // Console.ReadKey();

            //2

            //string a2 = Console.ReadLine();
            //int x2 = Convert.ToInt32(a2);
            //string y2 = Convert.ToString(x2);
            //Console.WriteLine("your naumber is: " + x2);


            //3


            //string a3 = Console.ReadLine();
            //Console.WriteLine("Uppercase: " + a3.ToUpper());
            //Console.WriteLine("Lowercase: " + a3.ToLower());



            //4


            //Console.WriteLine("Enter Your First Name :");
            //string a4 = Console.ReadLine();
            //Console.WriteLine("Enter Your Last Name :");
            //string a5 = Console.ReadLine();
            //Console.WriteLine("Your First Name :" + a4);
            //Console.WriteLine("Your Last Name :" + a5);
            //int lenght = a4.Length + a5.Length;
            //Console.WriteLine("Your Full Name Lenght :" + lenght);



            //5
            //Console.WriteLine("Input Two Numbers");
            //int a6 = Convert.ToInt32(Console.ReadLine());
            //int b6 = Convert.ToInt32(Console.ReadLine());
            //if (a6 > b6)
            //{
            //    Console.WriteLine("Smaller Number: " + b6);
            //}
            //else
            //{
            //    Console.WriteLine("Smaller Number: " + a6);
            //}



            //6
            //kitom();



            //7
            //htomin();

            //8
            //mintoh();


            //9 

            //compare();
            //sumofdigit();

            //10
            //reverse();


            //11

            //divisibility();

            //12
            middleValue();




        }
        static void kitom()
        {
            Console.WriteLine("Enter Kilometer");
            double km = Convert.ToDouble(Console.ReadLine());
            double m = km * 0.6214;
            Console.WriteLine(m + " mph");
        }

        static void htomin()
        {
            Console.WriteLine("Enter time in Hour and Min");
            double h = Convert.ToDouble(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double total = (h * 60) + min;
            Console.WriteLine("total " + total + " minutes");
        }
        static void mintoh()
        {
            Console.WriteLine("Enter time in Min");
            int min = Convert.ToInt32(Console.ReadLine());
            int totalh = (min / 60);
            int totalm = (int)min % 60;
            Console.WriteLine(" Hours," + totalh + " Minutes" + totalm);

        }

        static void compare()
        {

            Console.WriteLine("Input Two Numbers");
            int a6 = Convert.ToInt32(Console.ReadLine());
            int b6 = Convert.ToInt32(Console.ReadLine());
            if (a6 > b6)
            {
                Console.WriteLine("Smaller Number: " + b6);
            }
            else if (a6 == b6)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Smaller Number: " + a6);
            }

        }


        static void sumofdigit()
        {
            Console.WriteLine("Input Number");
            string a6 = Console.ReadLine();
            int b6 = Convert.ToInt32(a6[0]);
            int b7 = Convert.ToInt32(a6[1]);
            int b8 = Convert.ToInt32(a6[2]);
            int sum = b6 + b7 + b8;
            Console.WriteLine("Sum of digits:  " + sum);

        }

        static void reverse()
        {
            Console.WriteLine("Input Number");
            string a6 = Console.ReadLine();
            char[] arr = a6.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }

        static void divisibility()
        {
            Console.WriteLine("Input Number");
            int a6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the divide Number");
            int b6 = Convert.ToInt32(Console.ReadLine());
            if (a6 % b6 == 0)
            {
                Console.WriteLine("Divisible by " + b6);
            }
            else
            {
                Console.WriteLine("Not Divisible by " + b6);
            }
        }

        static void middleValue()
        {
            Console.WriteLine("Input Number");
            int a6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Number");
            int b6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Number");
            int c6 = Convert.ToInt32(Console.ReadLine());
            if (a6 > b6 && a6 < c6)
            {
                Console.WriteLine("Middle Number: " + a6);
            }
            else if (b6 > a6 && b6 < c6)
            {
                Console.WriteLine("Middle Number: " + b6);
            }
            else
            {
                Console.WriteLine("Middle Number: " + c6);
            }
        }

        }
}