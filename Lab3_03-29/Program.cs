using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_03_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubees!");

            bool run = true;
            while (run)
            {
                Console.WriteLine("Enter an integer:");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("Number      Squared      Cubed");
                Console.WriteLine("======      =======      =====");
                
                for (int i = 1; i <= input; i++)
                {
                    Console.WriteLine(i + "           " + Square(i) + "            " + Cube(i));
                }

                run = Continue();
            }
        }

        public static int Square(int num)
        {
            return num * num;
        }

        public static int Cube(int num)
        {
            return num * num * num;
        }

        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n):");
            string input = Console.ReadLine().ToLower();
            bool run = false;

            if (input == "n")
            {
                Console.WriteLine("Goodbye.");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type y/n:");
                run = Continue();
            }

            return run;
        }
    }
}
