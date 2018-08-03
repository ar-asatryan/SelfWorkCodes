using System;
using System.Linq;


namespace Tutorial
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            int inpNum = int.Parse(Console.ReadLine());
            int revNum = 0;
            int a;
            while (inpNum > 0)
            {
                a = inpNum % 10;
                revNum = revNum * 10 + a;
                inpNum /= 10;
            }
            Console.WriteLine($"Reverse Number is {revNum}");



            Console.ReadLine();
        }


    }
}

