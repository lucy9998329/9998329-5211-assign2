using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            string[] fruitsArray = new string[] {"Banana", "Grapefruit", "Tomato", "Oranges"};

            foreach(var fruit in fruitsArray) {
                Console.WriteLine(fruit);
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Reset();

            sw.Start();

            List<string> fruitsArray2 = new List<string> {"Banana", "Grapefruit", "Tomato", "Oranges"};

            foreach(var x in fruitsArray2) {
                Console.WriteLine(x);
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            }
        }
    }

