using System;

namespace First_Meeting
{
    class Forty_Two
    {
        public static void Main_()
        {
            Print(GetSquare(42));
        }

        public static int GetSquare(int a)
        {
            return a * a;
        }

        public static void Print(int a)
        {
            Console.WriteLine(a);
        }
    }
}
