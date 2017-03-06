using System;
using static System.Console;
namespace Cabana
{
    /*
     * Demonstrate Fibonacci
     * Credit : http://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
     */
    public class Fibonacci
    {
        public Fibonacci()
        {
            Write(new string('-', 25));
            Write(" Fibonucci BASIC ");
            Write(new string('-', 25));
            WriteLine();
            Fibonacci_Iterative(20);


            WriteLine();
            Write(new string('-', 25));
            Write(" Fibonucci Recursive");
            Write(new string('-', 25));
            WriteLine();
            Fibonacci_Recursive(20);
            WriteLine();

            Write(new string('-', 25));
            Write(" Fibonucci Get Nth ");
            Write(new string('-', 25));
            WriteLine();
            Write(GetNthFibonacci_Ite(18));
            WriteLine();

        }

        #region BASIC
        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            for (var i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
        #endregion

        #region  RECURSIVE

        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(0, 1, 1, len);
        }

        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }

        #endregion
        public static int GetNthFibonacci_Ite(int n)
        {
            int number = n - 1; //Need to decrement by 1 since we are starting from 0
            int[] fib = new int[number + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            return fib[number];
        }
    }
}