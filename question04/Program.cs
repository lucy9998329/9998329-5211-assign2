using System;

namespace question04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Print out the reverse timestables (highest number first) for:");
            
            int number = int.Parse(Console.ReadLine());
            

            for(int i = 13; i > 0; i--) 
            {

                if(i < 11) 
                {
                    Console.Write("0");
                }
                
                int a = i - 1;
                Console.WriteLine($"{a} x {number} = {a * number}");
            }
        }
    }
}
