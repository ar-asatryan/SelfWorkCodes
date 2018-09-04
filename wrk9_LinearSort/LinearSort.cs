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
            Console.WriteLine();
            PrintArr(arr);

            int[] countArrElems = new int[100];
            byte[] temparr = new byte[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                countArrElems[arr[i]] += 1;
            }

            int i1 = 0;
            int count = 0;
            for (byte i = 0; i < countArrElems.Length; i++)
            {
                Console.WriteLine($"i = {i} \r\n countArr[{i}] = {countArrElems[i]}");
                for (int j = i1; j < i1 + countArrElems[i]; j++)
                {
                    temparr[j] = i;
                    count++;
                }
                i1 += countArrElems[i];
                Console.WriteLine($"i1 = {i1}");
            }
            Console.WriteLine("Sorted Array>>>");
            Console.WriteLine($"Count loop {count}");
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


    }
}
