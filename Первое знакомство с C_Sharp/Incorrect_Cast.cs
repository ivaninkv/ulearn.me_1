using System;

namespace First_Meeting
{
    class Incorrect_Cast
    {
        public static void Main_()
        {
            double pi = Math.PI;
            int tenThousand = (int)10000L;
            float tenThousandPi = (float)pi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);

            Console.ReadKey();
        }
    }
}
