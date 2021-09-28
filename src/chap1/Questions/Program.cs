using System;


namespace Questions
{
    public class Questions
    {
        public static void Q1()
        {
            Console.WriteLine("Hello World");
        }

        public static void Q2()
        {
            int x = 11;
            Console.WriteLine($"x={x}");
        }

        public static void Q3()
        {
            int x = 13;
            int y = 17;
            Console.WriteLine($"x={x},y={y}");
        }

        public static void Q4()
        {
            int x = 13;
            int y = 17;
            x = x + y;
            Console.WriteLine(x);
        }

        public static void Q5()
        {
            int x = 13;
            int y = 17;
            Console.WriteLine(x + y);
        }

        public static void Q6()
        {
            int x = 7;
            x *= 3;
            Console.WriteLine(x);
            x /= 2;
            Console.WriteLine(x);
        }

        public static void Q7()
        {
            int x = 7;
            int y = 3;
            Console.WriteLine($"x={x},y={y}");
            (x, y) = (y, x);
            Console.WriteLine($"x={x},y={y}");
        }

        public static void Q8()
        {
            int x = 19;
            int y = 23;
            int z = x * y;
            Console.WriteLine(z);
        }

        public static void Q9()
        {
            int x = 3;
            for (int i = 2; i <= 4; i++)
            {
                Console.WriteLine(x * i);
            }
        }

        public static void Q10()
        {
            int x = 3;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(Math.Pow(x, i));
            }
        }

        public static void Q11()
        {
            int x = 10;
            for (int i = 1; i < x; i++)
            {
                int div = x / i;
                int mod = x % i;
                Console.WriteLine($"div={div}, mod={mod}");
            }
        }

        public static void Q12()
        {
            int x = 10;
            Console.WriteLine(x++);
            Console.WriteLine(x--);
            Console.WriteLine(--x);
            Console.WriteLine(++x);
        }

        static int Main()
        {
            return 0;
        }
    }
}