﻿namespace Assignment1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            //int
            Console.WriteLine("2. Create a simple console application and declare basic datatypes like int, float, decimal, double and print their min and max values.");
            Console.WriteLine();

            Console.WriteLine("Please enter a whole number (int): ");
            int numInput = Convert.ToInt32(Console.ReadLine());

            //float
            Console.WriteLine("Please enter a 'float' number (ex: 3.14f):");
            float floatInput = Convert.ToSingle(Console.ReadLine());

            //int
            Console.WriteLine("Please enter a whole number (int): ");
            int numInput2 = Convert.ToInt32(Console.ReadLine());

            //float
            Console.WriteLine("Please enter a 'float' number (ex: 3.14f):");
            float floatInput2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Min value of {numInput} & {floatInput} = " + Math.Min(numInput, floatInput));
            Console.WriteLine($"Max value of {numInput2} & {floatInput2} = " + Math.Max(numInput2, floatInput2));

        }
    }
}