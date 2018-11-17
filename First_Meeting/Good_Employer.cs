using System;

namespace First_Meeting
{
    class Good_Employer
    {
        private static string GetGreetingMessage(string name, double salary)
        {
            // возвращает "Hello, <name>, your salary is <salary>"
            salary = Math.Ceiling(salary);
            return String.Format("Hello, {0}, your salary is {1}", name, salary);
        }

        public static void Main_()
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
        }


    }
}
