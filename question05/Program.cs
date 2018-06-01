using System;

namespace question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the division table for:");

            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i < 12; i++) {
                int a = i + 1;
                Console.WriteLine($"{a} x {number} = {a / number}");
            }
        }
    }
}
