using System;

namespace wrk6_ArrsNumsLoops
{
    class ArrsNumsLoops
    {
        static void Main(string[] args)
        {
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            int[] array = new int[12];
            array[0] = 3;
            array[1] = 252;
            array[2] = -9;
            array[3] = 0;
            array[4] = 14;
            array[5] = 5;
            array[6] = 131;
            array[7] = 6;
            array[8] = 1;
            array[9] = 484;
            array[10] = 22;
            array[11] = 28;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }


            Console.ReadLine();
        }
    }
}
