using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 9.Население страны равно M млн чел., количество врачей – B млн чел.Прогнозируется ежегодный рост населения на р % и еже¬годное увели¬чение числа врачей на Q тыс. специалистов.Найти ко-личество врачей на 100 тыс.чел населения для каждого из ближай¬ших десяти лет.

namespace _16Zadach
{
    internal class _9
    {
        static void Main(string[] args)
        {
            Console.Write("Введите население страны M (в миллионах): ");
            double M = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество врачей B (в миллионах): ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежегодный рост населения p (%): ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежегодное увеличение числа врачей Q (в тысячах): ");
            double Q = Convert.ToDouble(Console.ReadLine());

            M *= 1000;
            B *= 1000;

            Console.WriteLine("\nГод | Население (тыс.) |Врачей на тыс. чел.");

            for (int year = 1; year <= 10; year++)
            {
                double doctorsPer100k = (B / M) * 100;

                Console.WriteLine($"{year,3} | {M: F0} | {B: F0} | {doctorsPer100k:F2}");

                M *= (1 + p / 100);

                B *= Q;
            }
        }
    }
}
