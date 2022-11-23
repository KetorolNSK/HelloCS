using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbtls in the range {int.MinValue} to {int.MaxValue}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbtls in the range {double.MinValue} to {double.MaxValue}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbtls in the range {decimal.MinValue} to {decimal.MaxValue}.");

            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equals 0.3");
            }

            decimal c = 0.1M;
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equals 0.3");
            }

            Console.WriteLine(double.NaN);
            Console.WriteLine(double.Epsilon);
            Console.WriteLine(double.NegativeInfinity);
        }
    }
}
