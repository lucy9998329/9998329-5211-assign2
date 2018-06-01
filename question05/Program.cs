using System;

namespace question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the division table for:");

            double number = double.Parse(Console.ReadLine());

            for(double i = 0; i < 12; i++) {
                double a = i + 1;
                Console.WriteLine($"{a} / {number} = {a / number}");
            }
        }
    }
}
