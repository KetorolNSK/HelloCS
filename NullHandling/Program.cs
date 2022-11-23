using System;

namespace NullHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            //thisCannotBeNull = null;

            int? thisCuoldBeNull = null;
            Console.WriteLine(thisCuoldBeNull);
            Console.WriteLine(thisCuoldBeNull.GetValueOrDefault());

            thisCuoldBeNull = 7;
            Console.WriteLine(thisCuoldBeNull);
            Console.WriteLine(thisCuoldBeNull.GetValueOrDefault());
        }
    }
}
