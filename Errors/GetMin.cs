﻿using System;

namespace Errors
{
    class GetMin
    {
        public static void Main()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:            
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");

            Console.ReadKey();
        }

        private static string GetMinX(int a, int b, int c)
        {
            if ((a < 0) || (a == 0 && b != 0))
                return "Impossible";
            else
            {
                if (a == 0 && b == 0)
                    return c.ToString();
                else
                    return (-b / (2.0 * a)).ToString();
            }
        }
    }
}
