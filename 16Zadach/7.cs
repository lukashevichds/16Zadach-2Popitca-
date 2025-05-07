using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 7.Начальная стоимость продукта равна C руб. Предполагаются ежеме¬сячное снижение на P руб. этой стоимости за счет совершен¬ствования технологии и ежемесячное увеличение на q % за счет роста стоимости электроэнергии. Вывести прогнозируемую стои¬мость продукта через 1, 2, ..., 10 мес.

namespace _16Zadach
{
    internal class _7
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную стоимость продукта (C): ");
            double C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежемесячное снижение стоимости (P): ");
            double P = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежемесячное увеличение стоимости в процентах (q): ");
            double q = Convert.ToDouble(Console.ReadLine());

            double increaseFactor = 1 + (q / 100);

            Console.WriteLine("\nПрогнозируемая стоимость продукта через месяцы: ");
            for (int month = 1; month <= 10; month++)
            {
                C = (C - P) * increaseFactor;

                Console.WriteLine($"Месяц {month}: {C:F2} руб.");
            }

        }
    }
}
