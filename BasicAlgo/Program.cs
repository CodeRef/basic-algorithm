using System;
using System.Diagnostics;
using static System.Console;
namespace Cabana
{
    class Program
    {

        static void Main(string[] args)
        {
            // Algorithm of Fibonucci
            new Fibonacci();
          
            // Algorithm of Tower of Hanoi
            WriteLine(); WriteLine(); WriteLine();
            Write(new string('-', 25));
            Write(" Tower of hanoi ");
            Write(new string('-', 25));
            WriteLine();

            TowerOfHanoi T = new TowerOfHanoi();
            Write("Enter the number of discs: ");
            var cnumdiscs = ReadLine();
            T.Numdiscs = Convert.ToInt32(cnumdiscs);
            T.Movetower(T.Numdiscs, 1, 3, 2);


            // Algorithm of Sorting
            WriteLine(); WriteLine(); WriteLine();
            new ArraySorting();

            // Algorithm of Searching.
            WriteLine(); WriteLine(); WriteLine();
            new Search();
            ReadKey();
        }
    }
}
