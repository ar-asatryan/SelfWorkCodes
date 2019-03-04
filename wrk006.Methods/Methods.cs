using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrk006.Methods
{
    class Methods
    {
        static void Main(string[] args)
        {
            //1.Method which generates Random Array with given minValue and maxValue>>
            //2.Method which prints in ConsApp given Array>>
            int[] arrRand = CreateRandomArr(10, 50, 100);            
            PrintArr(arrRand);

            //3.GetMax() method>>
            int maxElem = GetMax(arrRand);





            Console.ReadLine();
        }

        static int[] CreateRandomArr(int count, int minValue, int maxValue)
        {
            int[] arr = new int[count];
            var rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(minValue, maxValue);
            }

            return arr;
        }

        static void PrintArr(int[] arr)
        {
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return max;            
        }

        static int GetMax(int[] arr, out int maxIndex)
        {
            int max = arr[0];
            maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return max;
        }

        static int GetSecondMax(int[] arr)
        {
            int max = arr[0];
            int maxSecond = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i-1] > maxSecond)
                {
                    maxSecond = arr[i-1];
                    max = arr[i];
                    if (maxSecond < max)
                    {
                        return maxSecond;
                    }
                }
            }
            return maxSecond;
        }



    }
}
