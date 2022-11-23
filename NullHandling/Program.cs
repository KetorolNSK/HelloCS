using System;

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
#nullable enable
        static void Main(string[] args)
        {

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;




            int thisCannotBeNull = 4;
            //thisCannotBeNull = null;

            int? thisCuoldBeNull = null;
            Console.WriteLine(thisCuoldBeNull);
            Console.WriteLine(thisCuoldBeNull.GetValueOrDefault());

            thisCuoldBeNull = 75;
            Console.WriteLine(thisCuoldBeNull);
            Console.WriteLine(thisCuoldBeNull.GetValueOrDefault());

            string authorName = null;
            //int x = authorName.Length;
            int? x = authorName?.Length;
            var res = authorName?.Length ?? 3;
            Console.WriteLine(res);
        }
    }
}
