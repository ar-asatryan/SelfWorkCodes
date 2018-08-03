using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrk2_Operators
{
    class Operators
    {
        static void Main(string[] args)
        {
            Console.Write("Tipe A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Tipe B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Tipe C: ");
            int c = int.Parse(Console.ReadLine());


            //Տրված են a,b,c թվերը, գրեք ծրագիր, որը՝
            //- Կարտածի true, եթե տրված թվերից գոնե մեկը հավասար է 1֊ի, հակառակ դեպքում՝ false։
            //- Կարտածի true, եթե տրված թվերից երկուսը հավասար են երկուսի։
            //- Եթե այդպիսի երկարություն ունեցող հատվածներով հնարավոր է կազմել եռանկյունի, կարտածի true, հակառակ դեպքում՝ false։
            bool result1 = a == 1 || b == 1 || c == 1;
            bool result2 = (a == 2 && b == 2) || (a == 2 && c == 2) || (b == 2 && c == 2);
            string Triangle = (a < b + c) || (c < a + b) || (b < a + c) ? "Possible create Triangle" : "NOT Possible create Triangle";
            Console.WriteLine($"result1 is: {result1}");
            Console.WriteLine($"result2 is: {result2}");
            Console.WriteLine($"result3 is: {Triangle}");

            //Ներմուծեք եռանիշ թիվ և տպեք դրա նիշերը՝ առանձին-առանձին:
            Console.Write("Type Number by 3 Signs: ");
            int Num = int.Parse(Console.ReadLine());
            int n1 = Num / 100;
            int n2 = (Num / 10) % 10;
            int n3 = Num % 10;
            Console.WriteLine($" n1 = {n1}\r\n n2 = {n2}\r\n n3 = {n3}");

            //Ներմուծեք Հայկի, Վահանի ու Արսենի աշխատավարձերը, հաշվեք թե նրանցից ամենաշատ ստացողը որքան է շատ ստանում ամենաքիչ ստացողից։
            Console.Write("Type Salaries: ");
            double Salary_Hayk = double.Parse(Console.ReadLine());
            double Salary_Vahan = double.Parse(Console.ReadLine());
            double Salary_Arsen = double.Parse(Console.ReadLine());
            double[] Salaries = { Salary_Hayk, Salary_Vahan, Salary_Arsen };
            double MaxSalary = Salaries.Max();
            double MinSalary = Salaries.Min();
            Console.WriteLine($" Max Salari is: {MaxSalary} \r\n Min Salary is: {MinSalary} \r\n Diff is : {MaxSalary - MinSalary}");

            //Առանձին֊առանձին ներմուծեք DUD և AparanCity  սուպերմարկետներում հացի, կաթի, սուրճի, մածունի, պանրի գները, վերջում ասեք՝ որ սուպերմարկետում է ավելի ձեռնտու առևտուր անելը։
            Console.Write("Tipe bread_DUD: ");
            int bread_DUD = int.Parse(Console.ReadLine());
            Console.Write("Tipe bread_City: ");
            int bread_City = int.Parse(Console.ReadLine());
            Console.Write("Tipe milk_DUD: ");
            int milk_DUD = int.Parse(Console.ReadLine());
            Console.Write("Tipe milk_City: ");
            int milk_City = int.Parse(Console.ReadLine());
            Console.Write("Tipe coffee_DUD: ");
            int coffee_DUD = int.Parse(Console.ReadLine());
            Console.Write("Tipe coffee_City: ");
            int coffee_City = int.Parse(Console.ReadLine());

            int[] DUD = { bread_DUD, milk_DUD, coffee_DUD };
            int[] City = { bread_City, milk_City, coffee_City };

            if (DUD[0] + DUD[1] + DUD[2] < City[0] + City[1] + City[2])
            {

                Console.WriteLine("DUD is more cheaper:");
            }
            else

                if (DUD[0] + DUD[1] + DUD[2] > City[0] + City[1] + City[2])
            {
                Console.WriteLine("City is more cheaper:");
            }

            else
            {
                Console.WriteLine("both are the Same");
            }





            Console.ReadLine();
        }
    }
}
