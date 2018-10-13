using System;

namespace wrk004.Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.Write("Type N: ");
            int N = int.Parse(Console.ReadLine());

            //1.Արտածել 1-ից մինչև N բոլոր ամբողջ թվերը։
            Console.WriteLine($"Integer Numbers from 1 to {N} are:");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }

            //2.Արտածել 1-ից մինչև N բոլոր ամբողջ զույգ թվերը։
            Console.WriteLine($"Even Nums from 1 to {N} are:");
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //3.Արտածել 1-ից մինչև N բոլոր ամբողջ կենտ թվերը։
            Console.WriteLine($"Odd Nums from 1 to {N} are:");
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //4.Հաշվել 1-ից մինչև N բոլոր ամբողջ թվերի գումարը և արտածել այն։
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Summa is: {sum}");

            //5.Հաշվել a-ից մինչև b բոլոր ամբողջ թվերի գումարը և արտածել այն։
            Console.WriteLine("Type values of a and b: ");
            double sum_ab = 0;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i++)
            {
                sum_ab += i;
            }
            Console.WriteLine($"sum_ab = {sum_ab}");

            //6.Հաշվել 1-ից մինչև N բոլոր ամբողջ թվերի արտադրյալը և արտածել այն։
            int prod = 1;
            for (int i = 1; i <= N; i++)
            {
                prod *= i;
            }
            Console.WriteLine($"Product from 1 to {N} is: {prod}");

            //7.Տպել 1-999 միջակայքի այն թվերի գումարը, որոնց վրա առանց մնացորդի բաժանվում է տրված N բնական թիվը։
            int summa_999 = 0;
            for (int i = 1; i <= 999; i++)
            {
                if (N % i == 0)
                {
                    summa_999 += i;
                }
            }
            Console.WriteLine($"Summa for N%i==0 condition: {summa_999}");

            //8.Տպել 1-999 միջակայքի այն թվերի արտադրյալը, որոնց վրա առանց մնացորդի բաժանվում է տրված N բնական թիվը։
            int prod_999 = 1;
            for (int i = 1; i <= 999; i++)
            {
                if (N % i == 0)
                {
                    prod_999 *= i;
                }
            }
            Console.WriteLine($"Product for N%i==0 condition: {prod_999}");

            //9.Տպել 1-999 միջակայքի այն թվերի գումարը, որոնց վրա տրված N բնական թիվը բաժանելիս կմնա 2 մնացորդ։
            int sum_Tail2 = 0;
            for (int i = 1; i <= 999; i++)
            {
                if (N % i == 2)
                {
                    sum_Tail2 += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"summa for N%i==2 condition: {sum_Tail2}");

            //10.Տպել 1-999 միջակայքի այն թվերի արտադրյալը, որոնց վրա տրված N բնական թիվը բաժանելիս կմնա 3 մնացորդ։
            int prod_Tail3 = 1;
            for (int i = 1; i <= 999; i++)
            {
                if (N % i == 3)
                {
                    prod_Tail3 *= i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"product of N%i==3 condition is: {prod_Tail3}");

            //11.Տպել բոլոր երկնիշ թվերի գումարը, որոնք բազմապատիկ են 3 - ի։
            int sum_2n = 0;
            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum_2n += i;
                    //Console.WriteLine(i);
                }
            }
            Console.WriteLine($"summa for i%3==0  condition is: {sum_2n}");

            //12.Տպել բոլոր երկնիշ թվերի արտադրյալը, որոնք բազմապատիկ են 3 - ի և 5 - ի։
            int prod_2n = 1;
            for (int i = 10; i < 100; i++)
            {
                if (i % 15 == 0)
                {
                    prod_2n *= i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"product for i%15==0 condition: {prod_2n}");



            //13.Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնք բազմապատիկ չեն 5 - ի։
            int prod_3na = 1;
            for (int i = 100; i <= 999; i++)
            {
                if (i % 5 != 0)
                {
                    prod_3na *= i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"product for i%5 != 0 condition: {prod_3na}");



            //14.Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնք բազմապատիկ չեն 2 - ի և 3 - ի։
            int prod_3nb = 1;
            for (int i = 100; i <= 999; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    prod_3nb *= i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"product for <<i%2 != 0 && i % 3 != 0>> condition: {prod_3nb}");



            //15.Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնք 3 - ի բաժանելիս կմնա 1 մնացորդ, իսկ 4 - ի բաժանելիս՝ 2 մնացորդ։
            int prod_3nc = 1;
            for (int i = 100; i <= 999; i++)
            {
                if (i % 3 == 1 && i % 4 == 2)
                {
                    prod_3nc *= i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"product for <<i % 3 == 1 && i%4 == 2>> condition: {prod_3nc}");





            //16.Տպել ամենափոքր եռանիշ թիվը, որը 16 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի։            
            for (int i = 100; i <= 999; i++)
            {
                double A = i * 16;
                double B = Math.Sqrt(A);
                if (B - (int)B == 0)
                {
                    Console.WriteLine($"Min of i [i*16=A*A] is: {A / 16}");
                    break;
                }
            }

            //17.Տպել ամենափոքր քառանիշ թիվը, որը 26 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի։

            for (int i = 1000; i <= 9999; i++)
            {
                double t = i * 26;
                double h = Math.Sqrt(t);
                if (h - (int)h == 0)
                {
                    Console.WriteLine($"t=i*26={t} \r\n i = t/26 = {t / 26}");
                    break;
                }
            }

            //18.Տպել ամենամեծ քառանիշ թիվը, որը 14 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի։
            for (int i = 9999; i >= 1000; i--)
            {
                int num_14 = i * 14;
                double sqrtNum14 = Math.Sqrt(num_14);
                if (sqrtNum14 - (int)sqrtNum14 == 0)
                {
                    Console.WriteLine(num_14 / 14);
                    break;
                }
            }

            //19.Տպել ամենամեծ քառանիշ թիվը, որը 18 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի։
            for (int i = 9999; i >= 1000; i--)
            {
                int num_18 = i * 18;
                double sqrtNum18 = Math.Sqrt(num_18);
                if (sqrtNum18 - (int)sqrtNum18 == 0)
                {
                    Console.WriteLine(num_18 / 18);
                    break;
                }
            }

            //20.Տպել ամենափոքր եռանիշ թիվը, որի քառակուսի արմատը մեծ է տրված N բնական թվից։
            for (int i = 0; i <= 999; i++)
            {
                if (Math.Sqrt(i) > N)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("JazzRock");
                }
                else
                if (i % 3 == 0)
                {
                    Console.WriteLine("Jazz");
                }
                else
                if (i % 5 == 0)
                {
                    Console.WriteLine("Rock");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }





            Console.ReadLine();
        }
    }
}
