using System;
using System.Linq;


namespace Tutorial
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Type:");
            //int inputN = int.Parse(Console.ReadLine());

            int[] arr = CreateRandomArray();
            PrintArr(arr);

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


            for (int i = 0; i < arr.Length; i++)
            {
                if (Tutorial.MethodSimpNum(arr[i]) == 1)
                {
                    Console.WriteLine($"\r\nNumeric Average of Even Nums: {sum/count}");                    
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



        static int MethodSimpNum(int inputNumber)
        {
            int simpNum = 1;
            for (int i = 2; i < inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    simpNum = 0;
                }
            }
            return simpNum;
        }


        static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}  " );
            }
        }


        static void EvenNums(int[] arr)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += i;
                    count++;
                }
            }

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

