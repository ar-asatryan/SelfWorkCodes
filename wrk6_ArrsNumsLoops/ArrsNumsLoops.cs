using System;

namespace wrk6_ArrsNumsLoops
{
    class ArrsNumsLoops
    {
        static void Main(string[] args)
        {
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

            //4.Գտնել տրված թվի ամենամեծ թվանշանը:
            Console.WriteLine("Insert input Number>>");
            int inpNum = int.Parse(Console.ReadLine());
            int[] arrDigits = new int[inpNum.ToString().Length];
            Console.WriteLine($"The Length of an InpNum is:  {inpNum.ToString().Length}");
            int max = arrDigits[0];
            int digit;
            int ind = 0;
            while (inpNum != 0)
            {
                digit = inpNum % 10;
                Console.WriteLine($"digits >> {digit}");
                arrDigits[ind] = digit;
                ind++;
                inpNum /= 10;
            }

            for (int j = 0; j < arrDigits.Length; j++)
            {
                if (arrDigits[j] > max)
                {
                    max = arrDigits[j];
                }
            }

            Console.WriteLine("Digits Array>>");
            for (int k = 0; k < arrDigits.Length; k++)
            {
                Console.Write(arrDigits[k] + " ");
            }

            Console.WriteLine($"\r\nMaximum Digit of an input Number is>> {max}");


            //6.Տրված է զանգված....գտնել զանգվածում այն թվերը, որոնց ինդեքսները Ֆիբոնաչիի թվեր են։
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
