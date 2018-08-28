using System;
using System.Linq;


namespace Tutorial
{
    class Tutorial
    {
        static void Main(string[] args)
        {

            int[] arr = CreateRandomArray();
            Console.WriteLine("Please see Below Elements of an Random Array:");
            PrintArr(arr);

            for (int ind = 0; ind < arr.Length; ind++)
            {
                if (Tutorial.CheckPrimeNum(arr[ind]) == 1)
                {
                    double average = GetAverageForEvenNums(arr);
                    Console.WriteLine($"\r\nNumeric Average of Even Nums: {average}");                    
                }
                else
                {
                    Console.WriteLine($"\r\nMaximum element >> {MaxElementFromArray(arr)}");
                }
                break;
            }




            Console.ReadLine();
        }


        

        static int[] CreateRandomArray(int countArr = 15, int minValue = 50, int maxValue = 90)
        {
            int[] arrRand = new int[countArr];
            Random rand = new Random();

            for (int i = 0; i < arrRand.Length; i++)
            {
                arrRand[i] = rand.Next(minValue, maxValue);                
            }
            return arrRand;
        }





        static int CheckPrimeNum(int inputNumber)
        {
            int primeNum = 1;
            for (int i = 2; i < inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    primeNum = 0;
                }
            }
            return primeNum;
        }


        static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}  " );
            }
        }


        static double GetAverageForEvenNums(int[] arr)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            return sum / count;
        }


        static int MaxElementFromArray(int[] arr)
        {
            int max = arr[0];            
            for (int i = 0; i < (arr.Length - 1); i++)
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

