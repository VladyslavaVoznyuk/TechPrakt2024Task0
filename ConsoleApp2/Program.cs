using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first numeric:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second numeric:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine($"Sum of num {number1} and {number2} = : {sum}");

            Console.ReadLine(); 
        }
    }
}
