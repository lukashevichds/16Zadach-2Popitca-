using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 4. Урожайность пшеницы в год разработки целинных земель составила B ц/га, затраты на ее получение – D руб./га.По прогнозу в последующие годы урожайность будет уменьшаться на р % в год при увеличении затрат на q %. Найти себестоимость 1 ц пшеницы в каждый из последующих N лет.

namespace _16Zadach
{
    internal class _4
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную урожайность (B) в ц/га: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите затраты на получение (D) в руб./га: ");
            double D = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент уменьшения урожайности (p) в процентах: ");
            double p = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Введите процент увеличения затрат (q) в процентах: ");
            double q = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Введите количество лет (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int year = 0; year <= N; year++)
            {
                B *= (1 - p);
                D *= (1 + q);

                double costPerCenter = D / B;
                Console.WriteLine($"Себестоимость 1 ц пшеницы в {year}-й год: {costPerCenter: F2} руб");
            }
        }
    }
}
