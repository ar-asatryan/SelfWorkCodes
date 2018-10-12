using System;
using System.Linq;


namespace Tutorial
{
    class Tutorial
    {
        static void Main(string[] args)
        {
            int numInt = 15;
            decimal numDec;
            numDec = (decimal)numInt;
            decimal num = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"dec num is: {num}");
            Console.WriteLine($"casted 15 is: {numDec}");

            Console.ReadLine();
        }


    }
}

