using System;

namespace wrk003.Conditional
{
    class Conditional
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C-Sharp Programming");

            Console.WriteLine("Tipe a;b;c  inputs:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //Տրված են/ներմուծված են  իրարից տարբեր a,b,c թվերը, կազմել ծրագիր, որը՝
            //-Կարտածի դրանցից մեծագույնը	
            //-Կարտածի դրանցից փոքրագույնը	
            //-Կարտածի true, եթե տվյալ թվերը  թվաբանական պրոգրեսիա են կազմում, հակառակ դեպքում՝ false
            //-Կարտածի true, եթե տվյալ թվերը երկրաչափական պրոգրեսիա են կազմում, հակառակ դեպքում՝ false

            double max = a;
            if (a < b)
            {
                max = b;
                if (c > max)
                {
                    max = c;
                }
            }
            Console.WriteLine($"MAXabc =  { max }");


            double min = a;
            if (a > b)
            {
                min = b;
            }
            else
                if (c < min)
            {
                min = c;
            }
            Console.WriteLine($"MINabc =  { min }");


            if (a == (b + c) / 2 || b == (a + c) / 2 || c == (a + b) / 2)
            {
                Console.WriteLine("Numeric Progress!");
            }
            else { Console.WriteLine("No Progress..."); }

            //Լուծել a * x * x + b * x + c = 0 քառակուսային հավասարումը կամայական a, b և c թվերի համար։
            Console.WriteLine("Equation: ax*x + bx + c = 0");
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 && a != 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($" x1 = {x1}\r\n x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("No Solution...");
            }

            //Պարզել ներմուծված թիվը զու՞յգ է, թե՞ կենտ։
            if (a % 2 == 0)
            {
                Console.WriteLine($"The Number {a} is EVEN.");
            }
            else
            {
                Console.WriteLine($"The Number {a} is ODD.");
            }

            //Պարզել ներմուծված թիվը արդյոք բաժանվու՞մ է առանց մնացորդի 5-ի վրա։
            if (a % 5 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            //Ներմուծված թիվը բազմապատկել 2-ով, եթե այն զույգ է և առանց մնացորդի բաժանվում է 3-ի վրա։
            //Ներմուծված թիվը բազմապատկել 12-ով, եթե այն կենտ է կամ առանց մնացորդի բաժանվում է 3-ի վրա։
            if (a % 2 == 0 && a % 3 == 0)
            {
                Console.WriteLine($"ax2 = {a * 2}");
            }
            else if (a % 2 != 0 || a % 3 == 0)
            {
                Console.WriteLine($"ax12 = {a * 12}");
            }

















            Console.ReadLine();
        }
    }
}
