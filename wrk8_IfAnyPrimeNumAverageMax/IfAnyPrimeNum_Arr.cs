using System;

namespace wrk8_IfAnyPrimeNumAverageMax
{
    class IfAnyPrimeNum_Arr
    {
        static void Main(string[] args)
        {

            int[] inpArr = CreateRandomArr(count: 5);
            Console.WriteLine("Random Created Array>>");
            PrintArray(inpArr);
            Console.WriteLine();


            if (AnyPrimeNum(inpArr))
            {
                //Calculate the Numeric Average of an %2==0 integers.
                double average = GetAverageEvenNums(inpArr);
                Console.WriteLine($"Numeric Average>> {average}");
            }
            else
            {
                //calculate the Maximum Element of an Array.
                int max = GetMax(inpArr);
                Console.WriteLine($"Maximum of an Array>> {max}");
            }


            Console.ReadLine();
        }


        static int[] CreateRandomArr(int count = 15, int minValue = 50, int maxValue = 100)
        {
            int[] arr = new int[count];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(minValue, maxValue);
            }
            return arr;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }

        static bool AnyPrimeNum(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i < n/2; i=i+2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        static double GetAverageEvenNums(int[] arr)
        {
            double sum = 0;
            double count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2 == 0)
                {
                    count++;
                    sum += arr[i];
                }
            }
            return sum / count;
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }




    }
}
