using System;

namespace Questions
{
    public class Questions
    {
        public static int IntInput()
        {
            return int.Parse(Console.ReadLine());
        }

        public static (int, int ) _getXY()
        {
            int x = IntInput();
            int y = IntInput();
            return (x, y);
        }

        public static void Q1()
        {
            (int x, int y) = _getXY();
            if (x > y)
            {
                Console.WriteLine("xはyより大きい");
            }
        }

        public static void Q2()
        {
            (int x, int y) = _getXY();
            int ans = (x > y) ? x : y;
            Console.WriteLine(ans);
        }

        public static void Q3()
        {
            (int x, int y) = _getXY();
            if (x > y)
            {
                Console.WriteLine("xはyより大きい");
            }
            else if (x < y)
            {
                Console.WriteLine("xはyより小さい");
            }
        }

        public static void Q4()
        {
            (int x, int y) = _getXY();
            if (x > y)
            {
                Console.WriteLine("xはyより大きい");
            }
            else if (x < y)
            {
                Console.WriteLine("xはyより小さい");
            }
            else
            {
                Console.WriteLine("xとyは等しい");
            }
        }

        public static void Q5()
        {
            int x = IntInput();
            Console.WriteLine((x % 2 == 0) ? "偶数" : "奇数");
        }

        public static void Q6()
        {
            int x = IntInput();
            string ret1 = (x > 0) ? "正" : "負";
            string ret2 = (x % 2 == 0) ? "偶数" : "奇数";
            Console.WriteLine($"{ret1}の{ret2}");
        }


        public static void Q7()
        {
            int score = IntInput();
            Console.WriteLine((score >= 60) ? "合格" : "不合格");
            string case2;
            if (score >= 80)
            {
                case2 = "たいへんよくできました";
            }
            else if (score >= 60)
            {
                case2 = "よくできました";
            }
            else
            {
                case2 = "ざんねんでした";
            }

            Console.WriteLine(case2);

            string case3;
            if (score >= 80)
                case3 = "優";
            else if (score >= 70)
                case3 = "良";
            else if (score >= 60)
                case3 = "可";
            else
                case3 = "不可";
            Console.WriteLine(case3);
        }

        public static void Q8()
        {
            (int x, int y) = _getXY();
            string res;
            if ((x >= 60 && y >= 60) || x + y >= 130)
            {
                res = "合格";
            }
            else if (x + y >= 90 && (x >= 90 || y >= 90))
            {
                res = "合格";
            }
            else
            {
                res = "不合格";
            }

            Console.WriteLine(res);
        }

        public static void Q9()
        {
            Console.WriteLine("0=日曜、1=月曜、2=火曜、3=水曜、4=木曜、5=金曜、6=土曜");
            Console.WriteLine(">0=午前、1=午後、2=夜間");
            (int x, int y) = _getXY();
            bool isOpen;
            if ((x == 0) || ((x == 2 || x == 5) && y == 2))
            {
                isOpen = false;
            }
            else if ((x == 2 && y == 0) || (x == 6 && (y == 1 || y == 2)))
            {
                isOpen = false;
            }
            else
            {
                isOpen = true;
            }

            Console.WriteLine((isOpen) ? "診察中" : "休診");
        }

        static bool isEven(int num)
        {
            return (num % 2 == 0);
        }

        public static void Q10()
        {
            (int x, int y) = _getXY();
            if (x < y && isEven(x) && isEven(y))
            {
                Console.WriteLine("xはyより小さく、かつ、xとyは共に偶数である。");
            }

            if (x == y && x < 0)
            {
                Console.WriteLine("xとyは等しく、かつ、負の数である。");
            }

            if (x < y || isEven(x))
            {
                Console.WriteLine("xはyより小さい、または、xは偶数である。");
            }

            if ((x <= 10 || x >= 100) && 100 >= y && y >= 10)
            {
                Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である。");
            }

            if (!(x < 0 && y < 0))
            {
                Console.WriteLine("xもyも負の数である、ではない。");
            }
        }

        public static void Q11()
        {
            Console.WriteLine("おみくじ");
            Console.WriteLine("1-5の整数を1つ入力してください");

            int num = int.Parse(Console.ReadLine());
            string ret = num switch
            {
                1 => "吉",
                2 => "中吉",
                3 => "大吉",
                4 => "凶",
                5 => "吉",
                _ => "大凶"
            };
            Console.WriteLine(ret);
        }

        public static void Q12()
        {
            Console.WriteLine("何月ですか？");
            int month = int.Parse(Console.ReadLine());
            string ret = month switch
            {
                1 => "31日です",
                2 => "28日です",
                3 => "31日です",
                4 => "30日です",
                5 => "31日です",
                6 => "30日です",
                7 => "31日です",
                8 => "31日です",
                9 => "30日です",
                10 => "31日です",
                11 => "30日です",
                12 => "31日です",
                _ => "入力が間違っています"
            };
            Console.WriteLine(ret);
        }

        static int Main()
        {
            return 0;
        }
    }
}