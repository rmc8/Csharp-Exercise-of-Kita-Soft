using System;

namespace Questions
{
    public class Questions
    {
        public static void Q1()
        {
            string s = Console.ReadLine();
            Console.WriteLine(s);
        }

        public static void Q2()
        {
            string x = Console.ReadLine();
            Console.WriteLine(int.Parse(x));
        }

        public static void Q3()
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(Math.Pow(x, i));
            }
        }

        public static int intInput()
        {
            return int.Parse(Console.ReadLine());
        }

        public static void Q4()
        {
            int x = intInput();
            int y = intInput();
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
        }

        public static void Q5()
        {
            int x = intInput();
            int y = intInput();
            Console.WriteLine((x + y) / 2);
        }

        public static void Q6()
        {
            int old = intInput();
            int daysOfYear = 365;
            Console.WriteLine($"{old * daysOfYear}日");
        }

        public static int Main()
        {
            return 0;
        }
    }
}