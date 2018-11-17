using System;

namespace Errors
{
    class Misprint
    {
        public static void Main_()
        {
            Console.WriteLine("Hello, World!");
            var number = 5.5;
            number += 7;
            Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
