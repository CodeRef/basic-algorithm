using System;
using System.Diagnostics;

namespace Cabana
{
    using static System.Console;
    /*
     * Bubble Sort
     * Credit : http://www.c-sharpcorner.com/UploadFile/3d39b4/bubble-sort-in-C-Sharp/
     *        : http://stackoverflow.com/questions/14768010/simple-bubble-sort-c-sharp
     */
    public class ArraySorting
    {
        public ArraySorting()
        {
            Stopwatch watch = new Stopwatch();
            double elapsedTime;  // time in second, accurate to about millseconds


            Write(new string('-', 25));
            Write("Sort [Bubble sort]");
            Write(new string('-', 25));
            WriteLine();
            int[] arr = new int[10000];
            ArraySorting.IntArrayGenerate(arr, 12);
            watch.Start();
            ArraySorting.BubbleSort(arr);

            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            WriteLine(new string(' ', 10) + "Bubble Sort: {0:F3}", elapsedTime);
            WriteLine();

            watch.Reset();
            Write(new string('-', 25));
            Write("Sort [Selection sort]");
            Write(new string('-', 25));
            WriteLine();
            int[] arr2 = new int[10000];
            ArraySorting.IntArrayGenerate(arr2, 12);
            watch.Start();
            ArraySorting.IntArraySelectionSort(arr2);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            WriteLine(new string(' ', 10) + "Selection Sort: {0:F3}", elapsedTime);
            WriteLine();

            watch.Reset();
            Write(new string('-', 25));
            Write("Sort [Insertion sort]");
            Write(new string('-', 25));
            WriteLine();
            int[] arr3 = new int[10000];
            ArraySorting.IntArrayGenerate(arr3, 12);
            watch.Start();
            ArraySorting.IntArrayInsertionSort(arr3);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            WriteLine(new string(' ', 10) + "Insertion Sort: {0:F3}", elapsedTime);
            WriteLine();

            watch.Reset();
            Write(new string('-', 25));
            Write("Sort [Shell sort]");
            Write(new string('-', 25));
            WriteLine();
            int[] arr4 = new int[10000];
            ArraySorting.IntArrayGenerate(arr4, 12);
            watch.Start();
            ArraySorting.IntArrayShellSortNaive(arr4);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            WriteLine(new string(' ', 10) + "Shell Sort: {0:F3}", elapsedTime);

            WriteLine();
            watch.Reset();
            Write(new string('-', 30));
            Write("Sort [Quicksort a.k.a. Partition Sort]");
            Write(new string('-', 30));
            WriteLine();
            int[] arr5 = new int[10000];
            ArraySorting.IntArrayGenerate(arr5, 12);
            watch.Start();
            ArraySorting.IntArrayQuickSort(arr5);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            WriteLine(new string(' ', 10) + "Quicksort Sort: {0:F3}", elapsedTime);


            WriteLine();
            watch.Reset();
            Write(new string('-', 30));
            Write("Sort [Merge Sort Recursive]");
            Write(new string('-', 30));
            WriteLine();
            int[] arr6 = new int[10000];
            ArraySorting.IntArrayGenerate(arr5, 12);
            watch.Start();
            MergeSort_Recursive(arr6, 0, arr6.Length - 1);
            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            WriteLine(new string(' ', 10) + "Merge Sort Recursive: {0:F3}", elapsedTime);
        }

        public static void IntArrayGenerate(int[] data, int randomSeed)
        {
            Random r = new Random(randomSeed);
            for (int i = 0; i < data.Length; i++)
                data[i] = r.Next();
        }
        private static void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        #region Bubble Sort
        public static void BubbleSort(int[] a, int type = 0)
        {
            //WriteLine(string.Join(",", a));
            for (var i = 1; i <= a.Length - 1; ++i)
            {
                for (var j = 0; j < a.Length - i; ++j)
                {
                    if (type == 0)
                    {
                        if (a[j] > a[j + 1])
                        {
                            Swap(ref a[j], ref a[j + 1]);
                        }
                    }
                    else
                    {
                        if (a[j] < a[j + 1])
                        {
                            Swap(ref a[j], ref a[j + 1]);
                        }
                    }
                }
            }
            //WriteLine(string.Join(",", a));
        }



        #endregion

        #region Selection Sort
        /*
         * REFFERENCE : https://www.tutorialspoint.com/data_structures_algorithms/selection_sort_algorithm.htm
         * The Selection Sort algorithm works to minimize the amount of data movement, hence the number of Swap() calls.
         * CREDIT : https://www.tutorialspoint.com/data_structures_algorithms/selection_sort_algorithm.htm
         */
        public static int IntArrayMin(int[] data, int start)
        {
            var minPos = start;
            for (var pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }

        public static void IntArraySelectionSort(int[] data)
        {
            //WriteLine(string.Join(",", data));
            for (var i = 0; i < data.Length - 1; i++)
            {
                var k = IntArrayMin(data, i);
                if (i != k)
                    Swap(ref data[i], ref data[k]);
            }
            //WriteLine(string.Join(",", data));

        }
        #endregion

        #region Insertion Sort
        /*
         * REFFERENCE : https://www.tutorialspoint.com/data_structures_algorithms/bubble_sort_algorithm.htm
         * REFFERENCE : https://www.tutorialspoint.com/data_structures_algorithms/insertion_sort_algorithm.htm
         * In the Insertion Sort algorithm, we build a sorted list from the bottom of the array. We repeatedly insert the next element into the sorted part of the array by sliding it down (using our familiar Swap() method) to its proper position.
         *
         * This will require as many exchanges as Bubble Sort, since only one inversion is removed per exchange. 
         * So Insertion Sort also requires O(N2)O(N2) exchanges. 
         * On average Insertion Sort requires only half as many comparisons as Bubble Sort, 
         * since the average distance an element must move for random input is one-half the length of the sorted portion.
         * CREDIT : http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html
         */
        public static void IntArrayInsertionSort(int[] data)
        {
            //WriteLine(string.Join(",", data));
            for (var j = 1; j < data.Length; j++)
            {
                for (var i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    Swap(ref data[i], ref data[i - 1]);
                }
            }
            //WriteLine(string.Join(",", data));
        }

        #endregion

        #region Shell Sort
        /*
         * REFFERENCE : https://www.tutorialspoint.com/data_structures_algorithms/shell_sort_algorithm.htm
         * CREDIT : http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html
         */
        public static void IntArrayShellSort(int[] data, int[] intervals)
        {
            // The intervals for the shell sort must be sorted, ascending
            for (var k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (var m = 0; m < interval; m++)
                {
                    for (var j = m + interval; j < data.Length; j += interval)
                    {
                        for (var i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            Swap(ref data[i], ref data[i - interval]);
                        }
                    }
                }
            }
        }
        static int[] GenerateIntervals(int n)
        {
            if (n < 2)
            {  // no sorting will be needed
                return new int[0];
            }
            var t = Math.Max(1, (int)Math.Log(n, 3) - 1);
            var intervals = new int[t];
            intervals[0] = 1;
            for (var i = 1; i < t; i++)
                intervals[i] = 3 * intervals[i - 1] + 1;
            return intervals;
        }

        public static void IntArrayShellSortNaive(int[] data)
        {
            //WriteLine(string.Join(",", data));
            var intervals = GenerateIntervals(data.Length);
            IntArrayShellSort(data, intervals);
            //WriteLine(string.Join(",", data));
        }
        #endregion

        #region Quicksort a.k.a. Partition Sort
        /*
         * REFFERENCE : https://www.tutorialspoint.com/data_structures_algorithms/quick_sort_algorithm.htm
         * Quicksort is a rather interesting case. It is often perceived to be one of the best sorting algorithms but, in practice, has a worst case performance also on the order O(N2)O(N2). 
         * When the data are randomly sorted (as in our experiments) it does better at O(NlogN)O(Nlog⁡N).
         * CREDIT : http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html
         */
        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            var i = l;
            var j = r;

            var x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    Swap(ref data[i], ref data[j]);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        public static void IntArrayQuickSort(int[] data)
        {
            // WriteLine(string.Join(",", data));
            IntArrayQuickSort(data, 0, data.Length - 1);
            // WriteLine(string.Join(",", data));
        }

        #endregion

        #region Merge Sort Recursive
        /*
         * Refference : https://www.tutorialspoint.com/data_structures_algorithms/merge_sort_algorithm.htm
         * Credig : http://www.softwareandfinance.com/CSharp/MergeSort_Recursive.html
         */
        public static void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i;

            var leftEnd = (mid - 1);
            var tmpPos = left;
            var numElements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmpPos++] = numbers[left++];
                else
                    temp[tmpPos++] = numbers[mid++];
            }

            while (left <= leftEnd)
                temp[tmpPos++] = numbers[left++];

            while (mid <= right)
                temp[tmpPos++] = numbers[mid++];

            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public static void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            if (right > left)
            {
                var mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }
        #endregion
    }
}
