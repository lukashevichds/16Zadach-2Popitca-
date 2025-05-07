using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 15.Урожайность пшеницы в год разработки целинных земель составила B ц/га, затраты на ее получение – D руб./га. По прогнозу в последующие годы урожайность будет уменьшаться на р % в год при увеличении затрат на q %. Найти себестоимость 1 ц пшеницы в каждый из последующих N лет. Урожайность пшеницы в год разработки целинных земель соста¬вила B ц/га, затраты на ее получение—D руб./га. По прогнозу в по¬следующие годы урожайность будет уменьшаться на P руб. в год при увеличении затрат на q %. Вывести среднюю себестоимость 1 ц пшеницы за последующие N лет.

namespace _16Zadach
{
    internal class _15
    {
        static void Main(string[] args)
        {
            Console.Write("Введите урожайность (B) в ц/га: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите затраты (D) в руб./га: ");
            double D = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент уменьшения урожайности (p): ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент увеличения затрат (q): ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество лет (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            double currentYield = B;
            double currentCosts = D;
            double totalCostPerCenti = 0;

            Console.WriteLine("\nГод | Урожайность (ц/га) | Затраты (руб/га) | Себестоимость (руб./ц)");

            for (int year = 1; year <= N; year++)
            {
                double costPerCenter = currentCosts / currentYield;

                Console.Write($"{year,3} | {currentYield,19: F2} | {currentCosts,18: F2} | {costPerCenter,20: F2}");

                currentYield *= (1 - p / 100);
                currentCosts *= (1 + q / 100);

                totalCostPerCenti += costPerCenter;
            }

            double averageCostsPerCenti = totalCostPerCenti / N;

            Console.WriteLine($"\nСредняя себестоимость 1 й пшеницы за {N} лет: {averageCostsPerCenti: F2} руб./ц");
        }
    }
}
