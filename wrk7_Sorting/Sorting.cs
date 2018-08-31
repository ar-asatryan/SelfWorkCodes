using System;

namespace wrk7_Sorting
{
    class Sorting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type dimension of an Input Array:");
            int dim = int.Parse(Console.ReadLine());
            int[] inpArr = new int[dim];

            Console.WriteLine($"Type The Elements of your {dim}-size Array:");
            for (int ind = 0; ind < inpArr.Length; ind++)
            {
                inpArr[ind] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Input Array of an Integers:");
            for (int i = 0; i < inpArr.Length; i++)
            {
                Console.Write(inpArr[i] + " ");
            }
            Console.WriteLine("\r\n");

            BubbleSortedArray(inpArr);
            Console.WriteLine("Sorted Array>>");
            for (int k = 0; k < inpArr.Length; k++)
            {
                Console.Write(inpArr[k] + " ");
            }


            Console.WriteLine("\r\nRandom Array>>>");
            int[] arrRand = CreateRandomArray(count: 10, minValue: 50, maxValue: 100);
            for (int indRand = 0; indRand < arrRand.Length; indRand++)
            {
                Console.Write(arrRand[indRand] + " ");
            }
            BubbleSortedArray(arrRand);
            Console.WriteLine("\r\nRandom Array has Sorted>>");
            for (int i = 0; i < arrRand.Length; i++)
            {
                Console.Write(arrRand[i] + " ");
            }



            Console.ReadLine();
        }


        static void BubbleSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tempElem = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempElem;
                    }
                }
            }
        }

        static void Swap(int[] arr, int ind1, int ind2)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                                
            }
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



    }
}
