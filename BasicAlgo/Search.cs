using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Cabana
{
    public class Search
    {
        public Search()
        {
            WriteLine();
            WriteLine();
            int[] arr = { 11, 7, 22, 2, 33, 3, 17, 44, 4, 55, 5, 66, 6, 1, 77 };
            int? result = LinearSearch(55, arr);
            WriteLine("----------- Linear Search -----------------");
            WriteLine($@"[Linear Search] Index of 55 in [{string.Join(",", arr)}] is {result}");


            WriteLine("----------- Binary Search -----------------");
            const int searchInt = 44; // seach key
            var position = -1;
            // createarray and output it
            int[] searchArray = { 11, 7, 22, 2, 33, 3, 17, 44, 4, 55, 5, 66, 6, 1, 77 };// BinaryArray(15);
            Array.Sort(searchArray);
            // use binary search to try to find integer
            position = BinarySearch(searchArray, searchInt);

            // return value of -1 indicates integer was not found
            if (position == -1)
                WriteLine("The integer {0} was not found.\n", searchInt);
            else
                WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);
        }

        #region Linear Search
        /*
         * REFFERENCE : https://www.tutorialspoint.com/data_structures_algorithms/linear_search_algorithm.htm
         * Credit : https://begeeben.wordpress.com/2012/08/21/linear-search-in-c/
         */
        public static int? LinearSearch(int num, int[] arrayToSearch)
        {
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (arrayToSearch[i] == num)
                    return i;
            }

            return null;
        }
        #endregion

        #region Binary Search
        /*
         * Refference : https://www.tutorialspoint.com/data_structures_algorithms/binary_search_algorithm.htm
         * Credit : 
         */

        public int[] BinaryArray(int size)
        {
            var generator = new Random();
            var data = new int[size];
            for (var i = 0; i < size; i++)
            {
                data[i] = generator.Next(10, 100);
            }
            return data;
        }

        public int BinarySearch(int[] data, int searchElement)
        {
            var low = 0;
            var high = data.Length - 1;
            var middle = (low + high + 1) / 2;
            var location = -1;

            do
            {
                if (searchElement == data[middle])
                    location = middle;
                else if (searchElement < data[middle])
                    high = middle - 1;
                else
                    low = middle + 1;

                middle = (low + high + 1) / 2;
            } while ((low <= high) && (location == -1));

            return location;
        }


        #endregion
    }
}
