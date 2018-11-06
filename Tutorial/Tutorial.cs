using System;
using System.Collections.Generic;
using System.Linq;


namespace Tutorial
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            var inpArr = CreateRandomArr(20, 1, 50);
            var outArr = GetPrimeNums(inpArr);
            Print(outArr);

            
            int factNum = Factorial(5);

            
            

            Console.ReadLine();
        }


        static int Factorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }



        public static bool IsPrime(int num)
        {
            if (num < 2)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;
            for (int i = 3; i < Math.Sqrt(num); i += 2)
            {
                if (num%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> GetPrimeNums(int[] arr)
        {
            List<int> primeNums = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    primeNums.Add(arr[i]);
                }
            }
            return primeNums;
        }

        public static int[] CreateRandomArr(int count, int minValue, int maxValue)
        {
            Random rnd = new Random();
            var arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = rnd.Next(minValue,maxValue);
            }
            return arr;
        }

        static void Print(List<int> list)
        {
            int[] arr = list.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"elem{i} = {arr[i]}");
            }
        }


    }
}

