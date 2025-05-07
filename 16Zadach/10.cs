using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 10.Население страны составляет M млн чел. Прогнозируется ежегодная рождаемость р % от численности населения и смертность q %. Вычислить ежегодный прирост населения в течение ближайших N лет. C#

namespace _16Zadach
{
    internal class _10
    {
        static void Main(string[] args)
        {
            Console.Write("Введите население страны M (в миллионах): ");
            double M = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежегодную рождаемость p (%): ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежегодную смертность q (%): ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество лет N для прогноза: ");
            int N = Convert.ToInt32(Console.ReadLine());

            M *= 1000;

            Console.WriteLine("\n Год | Население (тыс.) | Прирост населения (тыс.)");

            for (int year = 1; year <= N; year++)
            {
                double brithRate = M * (p / 100);

                double deathRate = M * (q / 100);

                double populationGrowth = brithRate - deathRate;

                M *= populationGrowth;

                Console.WriteLine($"{year,3} | {M:F0} | {populationGrowth:F0}");
            }
        }
    }
}
