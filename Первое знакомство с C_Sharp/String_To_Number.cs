using System;

namespace Первое_знакомство_с_C_Sharp
{
    class String_To_Number
    {
        public static void Main_()
        {
            string doubleNumber = "894376.243643";
            double number = double.Parse(doubleNumber); // Вася уверен, что ошибка где-то тут
            Console.WriteLine(number + 1);

            Console.ReadKey();
        }
    }
}
