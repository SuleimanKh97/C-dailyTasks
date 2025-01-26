using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_23_01_25
{
    internal class Program
    {
        class Calculator
        {
            public void sum(int x, int y)
            {
                Console.WriteLine(x + y);
            }
            public void sum(int x, int y, int z)
            {
                Console.WriteLine(x + y + z);
            }
            public void sum(double x, double y)
            {
                Console.WriteLine(x + y);
            }

        }

        class shape
        {
            public virtual void draw()
            {
                Console.WriteLine("draw a shape");
            }
        }

        class Circle : shape
        {
            public override void draw()
            {
                Console.WriteLine("draw a Circle ");
            }
        }
        class Rectangle  : shape
        {
            public override void draw()
            {
                Console.WriteLine("draw a Rectangle  ");
            }
        }

        abstract class Animal
        {
            public abstract void makeSound();

            public void sleep()
            {
                Console.WriteLine("zzzzzz zzzzzz");
            }

        }

        class dog : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        class cat : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }

        interface Playable
        {
            void play();
        }

        class Guitar : Playable
        {
            public void play() 
            {
                Console.WriteLine("Playing the guitar.");
            }
        }

        class Piano  : Playable
        {
            public void play()
            {
                Console.WriteLine("Playing the Piano .");
            }
        }
        static void Main(string[] args)
            {
            Piano p = new Piano();
            p.play();

            Guitar g = new Guitar();
            g.play();

            dog d = new dog();
            d.makeSound();
            d.sleep();

            }
        }
    }
