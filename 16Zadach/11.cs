using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11.Население страны составляет M млн чел., из них р % городского. По прогнозу численность населения будет расти на b % ежегодно, а  доля городского населения – увеличиваться на q %. Определить предполагаемое количество городского и сельского населения страны в каждый из последующих N лет.

namespace _16Zadach
{
    internal class _11
    {
        static void Main(string[] args)
        {
            Console.Write("Введите население страны M (в миллионах): ");
            double M = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите долю городского населения r (%): ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежегодный рост населения b (%): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежегодное увеличение доли городского населения q (%): ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество лет N для прогноза: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nГод |Общее население (млн.)| Городское население (млн.)");

            for (int year = 1; year <= N; year++)
            {
                double urbanPopulation = M * (r / 100);
                double ruralPopulation = M * ((100 - r) / 100);

                Console.WriteLine($"{year,3} | {M:F2} | {urbanPopulation: F2} | {ruralPopulation: F2}");

                M *= (1 + b / 100);

                r *= q;

                if (r > 100) r = 100;
            }
        }
    }
}
