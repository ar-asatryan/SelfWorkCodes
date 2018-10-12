using System;

namespace wrk5_Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //9.Գրել ծրագիր, որը կպատճենի a զանգվածը b զանգվածի մեջ։
            //10.Գրել ծրագիր, որը կհակադարձի զանգվածը։
            //11.Գրել ծրագիր, որը կգումարի էլեմենտ առ էլեմենտ a և b զանգվածները և արդյունքը կպահի c զանգվածի մեջ։
            //12.Գրել ծրագիր, որը կբազմապատկի էլեմենտ առ էլեմենտ a և b զանգվածները և արդյունքը կպահի c զանգվածի մեջ։

            Console.WriteLine("Type Nsize: ");
            int N = int.Parse(Console.ReadLine());
            int[] arrInts = new int[N];
            int[] arrWeek = new int[] { 24, 25, 26, 27, 28, 29, 30 };

            //1.Ստեղծել միաչափ զանգված, որը կպարունակի ընթացիկ շաբաթվա ամսաթվերը։
            Console.WriteLine("days of Week:");
            for (int i = 0; i < arrWeek.Length; i++)
            {
                Console.WriteLine(arrWeek[i]);
            }

            //2.Գրել ցիկլ, որը կարտածի միաչափ զանգվածի էլեմենտները։
            Console.WriteLine($" Sequence of integers from 0 to {N}");
            for (int i = 0; i < arrInts.Length; i++)
            {
                Console.WriteLine(i);
            }

            //3.Ստեղծել n երկարությամբ միաչափ զանգված և ցիկլով ներմուծել զանգվածի էլեմենտների արժեքները։
            Console.WriteLine("Array Elements from Keyboard: ");
            for (int i = 0; i < arrInts.Length; i++)
            {
                arrInts[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrInts.Length; i++)
            {
                Console.Write($"{arrInts[i]}, ");
            }

            //4.Ստեղծել զանգված, որի էլեմենտները կպարունակեն 1-ից մինչև n ամբողջ թվերի քառակուսիները։
            Console.WriteLine("\r\nTypy Size of Array:");
            int sizeN = int.Parse(Console.ReadLine());
            int[] arrPows = new int[sizeN];
            for (int i = 0; i < arrPows.Length; i++)
            {
                arrPows[i] = i * i;
            }
            Console.WriteLine("\r\nSquare Array:");
            for (int i = 0; i < arrPows.Length; i++)
            {
                Console.Write($"{arrPows[i]}, ");
            }

            //5.Հաշվել թվային զանգվածի էլեմենտների գումարը։
            Console.WriteLine($"\r\nSumma of an Array Elements: 11, 32, 9.05, 49.8, 20, -33, 10.6");
            double sum = 0;
            double[] numArray = new double[] { 11, 32, 9.05, 49.8, 20, -33, 10.6 };
            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }
            Console.WriteLine(sum);

            //6.Հաշվել թվային զանգվածի էլեմենտների արտադրյալը։
            Console.WriteLine($"Product of an array elements:");
            int prod = 1;
            int[] numProd = { 12, 2, 4, 1, 3 };
            for (int i = 0; i < numProd.Length; i++)
            {
                prod *= numProd[i];
            }
            Console.WriteLine(prod);

            //7.Գտնել թվային զանգվածի էլեմենտներից փոքրագույնը։
            int[] arrMin = { 11, 33, 44, 5, 66 };
            int min = 0;
            Console.WriteLine("\r\nMinimum element of an Array {11, 33, 44, 5, 66} is:");
            for (int i = 0; i < (arrMin.Length - 1); i++)
            {
                min = arrMin[i];
                if (arrMin[i + 1] < arrMin[i])
                {
                    min = arrMin[i + 1];
                }
            }
            Console.WriteLine(min);
            
            //8.Գտնել թվային զանգվածի էլեմենտներից մեծագույնը։
            int[] arrMaxMin = { 1, 2, 9, 12, 0, 3 };






            Console.ReadLine();
        }
    }
}
