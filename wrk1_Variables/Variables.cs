using System;

namespace wrk1_Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipe text։");
            string var_1 = Console.ReadLine();
            Console.WriteLine(var_1);

            //1.Արտածեք Ձեր անունը, ազգանունը և տարիքը։
            //2.Հաշվել, թե a թիվը b թվի ո՞ր տոկոսն է կազմում օգտագործելով p = 100 * a / b բանաձևը։
            Console.WriteLine("Ararat Asatryan, 23 years old");
            Console.WriteLine("Type values of a and b:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double p = a * 100 / b;
            Console.WriteLine($"Result of How many per-cent is a of b: {p}");

            //3.Հաշվել r շառավղով շրջանի մակերեսը օգտագործելով a = pi * r * r բանաձևը։
            //4.Հաշվել r շառավղով շրջանագծի երկարությունը օգտագործելով c = 2 * pi * r բանաձևը։			
            Console.WriteLine("Please Type value of radius:");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double length = 2 * pi * r;
            double S = pi * (r * r);
            Console.WriteLine($"Length of Circle:L={length}\r\nSquare of Circle:S={S}");

            //5.Ներմուծեք ուղանկյան կողմերը, հաշվեք դրա պարագիծն ու մակերեսը:
            Console.WriteLine("Print sides of rectangle:");
            double side_1 = double.Parse(Console.ReadLine());
            double side_2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"S = {side_1 * side_2} \r\nP = {2 * side_1 + 2 * side_2}");

            //6.Հաշվել, թե քանի վայրկյան կա n քանակությամբ օրերում։
            Console.WriteLine("Type number of days:");
            int sec = 1;
            sec = 1;
            int minute = 60 * sec;
            int hour = 60 * minute;
            int day = 24 * hour;
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Seconds in N={N} days will be {N * day}");

            //7.Ներմուծեք երկու կոտորակային թիվ, տպեք դրանց գումարը՝ 1. որպես ամբողջ թիվ, 2. որպես կոտորակային թիվ:
            double frac1 = (double)1 / 3;
            double frac2 = (double)2 / 3;
            double sumFrac = frac1 + frac2;
            Console.WriteLine(sumFrac);
            Console.WriteLine($"{frac1}+{frac2}");



            Console.ReadLine();
        }
    }
}
