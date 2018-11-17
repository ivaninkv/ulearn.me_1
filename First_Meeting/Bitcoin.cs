using System;

namespace First_Meeting
{
    class Bitcoin
    {
        public static void Main_()
        {
            double amount = 1.11; //количество биткоинов от одного человека
            int peopleCount = 60; // количество человек
            int totalMoney = (int)Math.Round(amount * peopleCount); // ← исправьте ошибку в этой строке
            Console.WriteLine(totalMoney);

            Console.ReadKey();
        }
    }
}
