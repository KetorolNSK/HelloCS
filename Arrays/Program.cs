using System;
using static System.Convert;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names;
            string[] names = new string[4];
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            string[] names1 = { "Adam", "Barry", "Chrlie" };
            foreach (var item in names1)
            {
                Console.WriteLine(item.Length);
            }

            double[] doubles = { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            foreach (var d in doubles)
            {
                //Console.WriteLine($"{d} == {ToInt32(d)}");

                Console.WriteLine(format:
                     "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                     arg0: d,
                     arg1: Math.Round(value: d,
                     digits: 0,
                     mode: MidpointRounding.AwayFromZero));
            }


            int number = 12;
            Console.WriteLine(number.ToString());
            bool boolean = true;
            Console.WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            object me = new object();
            Console.WriteLine(me.ToString());



            int age = int.Parse("43");
            DateTime birthday = DateTime.Parse("9 November 1979");

            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}");

            //int count = int.Parse("abc");

            Console.WriteLine("How many eggs are there?");
            int count;
            string input = Console.ReadLine();

            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input");
            }
        }

    }
}
