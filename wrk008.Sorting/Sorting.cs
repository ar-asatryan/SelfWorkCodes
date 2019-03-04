using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrk008.Sorting
{
    class Sorting
    {
        static void Main(string[] args)
        {
            //int[] arr = { 12, 9, 0, 7, 77, 1, 36, 8 };
            int[] arr = CreateRandomArray(count: 5000, minValue: 1, maxValue: 1000000);

            DateTime dt = DateTime.Now;
            SortSelectionAscending(arr);
            TimeSpan time = DateTime.Now - dt;
            Console.WriteLine($"Selection Sort Time: {time}");


            dt = DateTime.Now;
            BubbleSort(arr);
            time = DateTime.Now - dt;
            Console.WriteLine($"Bubble Sort Time: {time}");


            Console.ReadLine();

        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isSorted = true;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        isSorted = false;
                    }
                }
                if (isSorted)
                {
                    return;
                }
            }
        }

        static int[] SortSelectionAscending(params int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(arr, i, j);
                    }
                }
            }
            return arr;
        }

        static int[] CreateRandomArray(int count, int minValue, int maxValue)
        {
            int[] arr = new int[count];
            Random rand = new Random();
            for (int ind = 0; ind < arr.Length; ind++)
            {
                arr[ind] = rand.Next(minValue, maxValue);
            }
            return arr;
        }

        static int GetMinIndex(int[] arr, int startIndex)
        {
            int index = startIndex;
            int min = arr[index];
            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    index = i;
                }
            }
            return index;
        }

        static void Swap(int[] arr, int i1, int i2)
        {
            int temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
        }


    }
}
