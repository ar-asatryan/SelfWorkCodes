using System;
using System.Linq;


namespace Tutorial
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            int[] arr = CreateRandomArr(100);

            //Console.ReadLine();
        }


        static int[] CreateRandomArr(int n)
        {
            
            int[] arr = new int[n];

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10, 100);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}: {arr[i]}");
            }
            return arr;
        }


    }
}

