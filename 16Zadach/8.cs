using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 8.Заработная плата Z специалиста составляет R руб.; текущий курс доллара – B руб. Прогнозируются ежемесячные падение курса дол¬лара q % и рост величины Z р % (по отношению к предыду¬щему ме¬сяцу). Найти долларовый эквивалент Z для каждого из по¬следующих 6 мес.

namespace _16Zadach
{
    internal class _8
    {
        static void Main(string[] args)
        {
            Console.Write("Введите заработную плату Z (в рублях): ");
            double Z = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите текущий курс доллара B (в рублях): ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежемесячное падение курса доллара q (%): ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежемесячный рост заработной платы p (%): ");
            double p = Convert.ToDouble(Console.ReadLine());

            double decreaseFactor = 1 - (q / 100);
            double increaseFactor = 1 + (q / 100);

            Console.WriteLine("\nМесяц |Заработная плата (руб.)|Курс доллара (руб.)|Эквивалент в долларах");

            for (int month = 1; month <= 6; month++)
            {
                double dollarEquivalent = Z / B;

                Console.WriteLine($"{month,5} | {Z: F2} | {B: F2} | {dollarEquivalent: F2}");

                Z *= increaseFactor;

                B *= decreaseFactor;
            }
        }
    }
}
