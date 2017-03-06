using System;
using System.Diagnostics;
using static System.Console;
namespace Cabana
{
    class Program
    {

        static void Main(string[] args)
        {
            new Fibonacci();
            //Write(new string('-', 25));
            //Write(" Fibonucci BASIC ");
            //Write(new string('-', 25));
            //WriteLine();
            //Fibonacci.Fibonacci_Iterative(20);


            //WriteLine();
            //Write(new string('-', 25));
            //Write(" Fibonucci Recursive");
            //Write(new string('-', 25));
            //WriteLine();
            //Fibonacci.Fibonacci_Recursive(20);
            //WriteLine();

            //Write(new string('-', 25));
            //Write(" Fibonucci Get Nth ");
            //Write(new string('-', 25));
            //WriteLine();
            //Write(Fibonacci.GetNthFibonacci_Ite(18));
            //WriteLine();
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
            WriteLine(); WriteLine(); WriteLine();
            new ArraySorting();

            //WriteLine("----------------------- Array Sorting ---------------------");
            //Stopwatch watch = new Stopwatch();
            //double elapsedTime;  // time in second, accurate to about millseconds


            //Write(new string('-', 25));
            //Write("Sort [Bubble sort]");
            //Write(new string('-', 25));
            //WriteLine();
            //int[] arr = new int[10000];// { 800, 11, 25, 771, 649, 770, 240, 9 };
            //ArraySorting.IntArrayGenerate(arr, 12);
            //watch.Start();
            //ArraySorting.BubbleSort(arr);

            //watch.Stop();
            //elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            //WriteLine(new string(' ',10)+ "Bubble Sort: {0:F3}", elapsedTime);
            //WriteLine();

            //watch.Reset();
            //Write(new string('-', 25));
            //Write("Sort [Selection sort]");
            //Write(new string('-', 25));
            //WriteLine();
            //int[] arr2 = new int[10000];// { 800, 11, 25, 771, 649, 770, 240, 9 };
            //ArraySorting.IntArrayGenerate(arr2, 12);
            //watch.Start();
            //ArraySorting.IntArraySelectionSort(arr2);
            //watch.Stop();
            //elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            //WriteLine(new string(' ', 10) + "Selection Sort: {0:F3}", elapsedTime);
            //WriteLine();

            //watch.Reset();
            //Write(new string('-', 25));
            //Write("Sort [Insertion sort]");
            //Write(new string('-', 25));
            //WriteLine();
            //int[] arr3 = new int[10000];// { 800, 11, 25, 771, 649, 770, 240, 9 };
            //ArraySorting.IntArrayGenerate(arr3, 12);
            //watch.Start();
            //ArraySorting.IntArrayInsertionSort(arr3);
            //watch.Stop();
            //elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            //WriteLine(new string(' ', 10) + "Insertion Sort: {0:F3}", elapsedTime);
            //WriteLine();

            //watch.Reset();
            //Write(new string('-', 25));
            //Write("Sort [Shell sort]");
            //Write(new string('-', 25));
            //WriteLine();
            //int[] arr4 = new int[10000];// { 800, 11, 25, 771, 649, 770, 240, 9 };
            //ArraySorting.IntArrayGenerate(arr4, 12);
            //watch.Start();
            //ArraySorting.IntArrayShellSortNaive(arr4);
            //watch.Stop();
            //elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            //WriteLine(new string(' ', 10) + "Shell Sort: {0:F3}", elapsedTime);

            //WriteLine();
            //watch.Reset();
            //Write(new string('-', 30));
            //Write("Sort [Quicksort a.k.a. Partition Sort]");
            //Write(new string('-', 30));
            //WriteLine();
            //int[] arr5 = new int[10000];// { 800, 11, 25, 771, 649, 770, 240, 9 };
            //ArraySorting.IntArrayGenerate(arr5, 12);
            //watch.Start();
            //ArraySorting.IntArrayQuickSort(arr5);
            //watch.Stop();
            //elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            //WriteLine(new string(' ', 10) + "Quicksort Sort: {0:F3}", elapsedTime);
            new Search();
            ReadKey();
        }
    }
}
