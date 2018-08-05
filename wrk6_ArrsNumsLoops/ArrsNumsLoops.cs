using System;

namespace wrk6_ArrsNumsLoops
{
    class ArrsNumsLoops
    {
        static void Main(string[] args)
        {
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            int[] array = new int[14];
            array[0] = 3;
            array[1] = 252;
            array[2] = -9;
            array[3] = 0;
            array[4] = 14;
            array[5] = 5;
            array[6] = 131;
            array[7] = 6;
            array[8] = 7913;
            array[9] = 484;
            array[10] = 22;
            array[11] = 28;
            array[12] = 1;
            array[13] = 909;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }

            //տրված է զանգված....գտնել զանգվածում այն թվերը, որոնց ինդեքսները Ֆիբոնաչիի թվեր են։
            Console.Write("Insert Dimension of Fibonacci Sequence: ");
            int indexFib = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int numFib = 0;
            int[] arrFib = new int[indexFib];
            for (int i = 0; i < indexFib; i++)
            {
                arrFib[i] = numFib;
                numFib = a + b;
                a = b;
                b = numFib;
            }

            Console.WriteLine("Sequence of Fibonacci");
            for (int i = 0; i < arrFib.Length; i++)
            {
                Console.Write(arrFib[i] + " ");
            }


            Console.WriteLine("\r\nresult is:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < arrFib.Length; k++)
                {
                    if (i == arrFib[k])
                    {
                        Console.WriteLine($"index{i}>>>{array[i]}");
                    }
                }
            }






            Console.ReadLine();
        }
    }
}
