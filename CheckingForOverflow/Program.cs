using System;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                checked
                {
                    int x = int.MaxValue - 1;
                    Console.WriteLine($"Initial value: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                }

            }
            catch(OverflowException)
            {
                Console.WriteLine("The code overflowed but I caught the exception");
            }

            unchecked
            {
                int y = int.MaxValue + 1;

                Console.WriteLine($"Initial value: {y}");
                y--;
                Console.WriteLine($"After decrementing: {y}");
                y--;
                Console.WriteLine($"After decrementing: {y}");
            }

            for (int row = 0; row <= 12; row++)
            {
                Console.WriteLine($"{row} x 12 = {row * 12}");
            }
        }
 
    }
}
