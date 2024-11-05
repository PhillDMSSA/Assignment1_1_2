namespace Assignment1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           //2.

            //int
            Console.WriteLine("2. Create a simple console application and declare basic datatypes like int, float, decimal, double and print their min and max values.");
            Console.WriteLine();

            Console.WriteLine("\tPlease enter a whole number (int): ");
            int numInput = Convert.ToInt32(Console.ReadLine());

            //float
            Console.WriteLine("\tPlease enter a 'float' number (ex: 3.14f):");
            float floatInput = Convert.ToSingle(Console.ReadLine());

            //int
            Console.WriteLine("\tPlease enter a whole number (int): ");
            int numInput2 = Convert.ToInt32(Console.ReadLine());

            //float
            Console.WriteLine("\tPlease enter a 'float' number (ex: 3.14f):");
            float floatInput2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"\t\t\t\tMin value of {numInput} & {floatInput} = " + Math.Min(numInput, floatInput));
            Console.WriteLine($"\t\t\t\tMax value of {numInput2} & {floatInput2} = " + Math.Max(numInput2, floatInput2));

         
            //3.

            Console.WriteLine();
            Console.WriteLine("3. Write a C# Sharp program to print the sum of two numbers.");
            Console.WriteLine("\tEnter a number: ");
            int numberInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\tEnter another number: ");
            int numberInput2 = Convert.ToInt32(Console.ReadLine());

            int sum = numberInput1 + numberInput2;

            Console.WriteLine($"\t\t\t\tThe sum of the 2 numbers entered is: {sum}. ({numberInput1} " +
                $"+ {numberInput2} = {sum}) ");

            //4.

            Console.WriteLine();
            Console.WriteLine("4. Write a C# Sharp program to print the result of dividing two numbers.");
            Console.WriteLine("\tEnter a number: ");
            double numberInput12 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\tEnter another number: ");
            double numberInput13 = Convert.ToDouble(Console.ReadLine());

            double sum2 = numberInput12 / numberInput13;

            Console.WriteLine($"\t\t\t\t{numberInput12} / {numberInput13} = {sum2}");

        }
    }
}
