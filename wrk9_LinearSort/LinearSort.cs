using System;

namespace wrk9_LinearSort
{
    class LinearSort
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte[] arr = new byte[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (byte)rand.Next(0, 100);
            }
            //PrintArr(arr);

            int[] countArrElems = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                countArrElems[arr[i]] += 1;
            }
            //Console.WriteLine("Count Array>>");
            //PrintArrInt(countarr);

            int i1 = 0;
            byte[] temparr = new byte[1000];
            for (byte i = 0; i < countArrElems.Length; i++)
            {
                Console.WriteLine($"i = {i} \r\n countarr[i] = {countArrElems[i]}");
                for (int j = i1; j < i1 + countArrElems[i]; j++)
                {
                    temparr[j] = i;
                }
                i1 += countArrElems[i];
                Console.WriteLine($"i1 = {i1}");
            }
            Console.WriteLine("Sorted Array>>>");
            PrintArr(temparr);






            Console.ReadLine();
        }


        static void PrintArr(byte[] arr)
        {
            foreach (byte item in arr)
            {
                Console.Write(item + " ");
            }
        }



        static void PrintArrInt(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }


    }
}
