using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_20_01_25
{
    internal class Program
    {

        class roomsinhotel
        {
            public int roomnumber;
            public string roomtype;
            public string roomstatus;
            public double roomprice;
            public const string hotelname = "The Grand Hotel";
        }
        static void Main(string[] args)
        {

            //roomsinhotel room1 = new roomsinhotel();
            //Console.WriteLine("Enter Room Number: ");
            //room1.roomnumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Room Type:  (e.g., Single, Double, Suite)");
            //room1.roomtype = Console.ReadLine();

            //room1.roomstatus = "Available";
            //room1.roomprice = 89.99;

            //Console.WriteLine("Welcome To: " + roomsinhotel.hotelname);
            //Console.WriteLine("Room Number: " + room1.roomnumber);
            //Console.WriteLine("Room type: " + room1.roomtype);
            //Console.WriteLine("Room status: " + room1.roomstatus);
            //Console.WriteLine("Room price: $" + room1.roomprice);


            //CountVowels();

            //1

            //Console.WriteLine("enter a number to check if even or odd");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(isevenorodd(a));

            //2
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Enter 5 numbers: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("the SEcond smallest is : ");
            //Console.WriteLine(thesecondsmallest(arr));


            //3factorial

            //Console.WriteLine("enter a nuber to calculate factorial");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("the Result is : " + factorial(a));


            //4 not completed
            //prime(10 , 20);


            //5 largest

            //Console.WriteLine("Enter size of array: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //int[] arr;
            //arr = new int[a];
            //Console.WriteLine("Enter the Numbers: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //largest(arr);


            //6 pattern 
            //Console.WriteLine("Enter the Number Of Rows: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //pattern(a);


            //7 pyramid pattern 
            //Console.WriteLine("Enter the Number Of Rows for Stars: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //pyramidpattern(a);

            //8 calculates even and odds

            //Console.WriteLine("Enter size of array to calculate odd and even sum: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //int[] arr;
            //arr = new int[a];
            //Console.WriteLine("Enter the Numbers: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //evenandodd(arr);

            //9  compares two arrays 


            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr2 = { 3, 4, 5, 6 };

            //Console.Write("The Common Numbers is : ");
            //comparestwoarrays(arr1, arr2);












        }

        static void CountVowels()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            int count = 0;
            foreach (char c in input)
            {
                if ("aeiou".Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine("Number of vowels: " + count);
        }

        static string isevenorodd(int a)
        {
            if (a % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        static int thesecondsmallest(int[] arr)
        {
            int smallest = arr[0];
            int secondsmallest = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    secondsmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < secondsmallest && arr[i] > smallest)
                {
                    secondsmallest = arr[i];
                }
            }
            return secondsmallest;

        }

        static int factorial(int a)
        {
            int multi = 1;
            for (int i = 1; i <= a; i++)
            {
                multi = multi * i;
            }
            return multi;
        }

        static void prime(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (j % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                        break;
                    }
                    else
                    {

                        Console.WriteLine("prime" + j);
                        break;

                    }
                }
            }
        }

        //public static void prime(int a)
        //{
        //    int x = a;
        //    for (int i = 2; i < x; i++)
        //    {
        //        if (x % i == 0)
        //        {
        //            Console.WriteLine("Not Prime");
        //            break;
        //        }
        //        else
        //        {

        //            Console.WriteLine("prime");
        //            break;

        //        }
        //    }
        //}


        static void largest(int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("the largest number is : " + max);
        }

        static void pattern(int a)
        {
            int count = 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(" " + count);
                    count++;
                }
                Console.WriteLine(" ");
            }
        }

        static void pyramidpattern(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        static void evenandodd(int[] arr)
        {
            int odd = 0;
            int even = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    even = even + i;
                }
                else
                {
                    odd = odd + i;
                }
            }
            Console.WriteLine("the sum of even numbers is : " + even);
            Console.WriteLine("the sum of odd numbers is : " + odd);

        }

        static void comparestwoarrays(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write("  " + arr2[j] + "  ");
                    }
                }
            }
        }

    }
}
