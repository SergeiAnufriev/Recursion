using System;

namespace Recursion
{
    class Program
    {
        // Рекурсивный метод
        /*static void natural(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void PrintNDigits(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Базовый cлучай n = 1");
                return;
            }

            Console.WriteLine("Рекурсивный вызов с n=" + n);
            PrintNDigits(n - 1);
            Console.WriteLine(n);
        }

       static void TwoNumbers(int n1, int n2)
       {
           if (n1 == n2)
           {
               Console.WriteLine(n1);
               return;
           }

           if (n1 > n2)
           {
               Console.WriteLine(n1);
               TwoNumbers(n1 - 1, n2);

           }
           else
           {
               Console.WriteLine(n1);
               TwoNumbers(n1 + 1, n2);
           }
       }

       static int Akkerman(int m, int n)
       {
           if (m == 0)
           {
               return   n + 1;

           }

           if (m > 0 && n == 0)
           {
               return  Akkerman(m - 1, 1);
           }

           if (m > 0 && n > 0)
           {
               return  Akkerman(m - 1, Akkerman(m, n - 1));
           }

           return 0;
       }*/

        static void Power(float n)
        {
            if (n == 2)
            {
                Console.WriteLine("Yes");
                return;
            }

            if (n < 2)
            {
                Console.WriteLine("No");
                return;
            }
            else
            {
                Power(n / 2);
            }
        }

        static void DigitsOfNumber(int n)
        {
            float x = 0;

            if (n < 10)
            {
                Console.WriteLine(n);
                return;
            }
            else
            {
                x = n % 10;
                Console.WriteLine(x);
                DigitsOfNumber(n / 10);
            }
        }

        static void DigitsOfNumber2(int n)
        {
            float x = 0;

            if (n < 10)
            {
                Console.WriteLine(n);
                return;
            }
            else
            {
                x = n % 10;
                
                DigitsOfNumber2(n / 10);
                Console.WriteLine(x);
            }
        }


        public static void Main(string[] args)
        {

            Console.Write("Введите число: ");

            // int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
           // Power(n);

            DigitsOfNumber2(n);

            //int x = Akkerman(m, n);

            //Console.WriteLine(x);

            Console.ReadLine();

        }
    }
}
