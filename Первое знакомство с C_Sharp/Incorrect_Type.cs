﻿using System;

namespace Первое_знакомство_с_C_Sharp
{
    class Incorrect_Type
    {
        public static void Main_()
        {
            double num1 = +5.5e-2;
            float num2 = 7.8f;
            int num3 = 0;
            long num4 = 2000000000000L;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            Console.ReadKey();
        }
    }
}
