using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 16.Начальная стоимость продукта равна C руб. Предполагаются ежеме¬сячное снижение на P руб. этой стоимости за счет совершен¬ствования технологии и ежемесячное увеличение на q % за счет роста стоимости электроэнергии. Вывести прогнозируемую стои¬мость продукта через 1, 2, ..., 10 мес Начальная стоимость продукта равна C руб.. Предполагается ежеме¬сяч¬ное снижение стоимости на Р руб. за счет совер¬шен¬ство¬вания технологии и ежемесячное увеличение на q % из-за роста стои¬мости электроэнергии. Вывести среднюю стоимость продукта за 10 мес.

namespace _16Zadach
{
    internal class _16
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную стоимость продукта (C) в руб.: ");
            double C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежемесячное снижение стоимости (P) в руб.: ");
            double P = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежемесячное увеличение стоимости (q) в %: ");
            double q = Convert.ToDouble(Console.ReadLine());

            double currentPrice = C;
            double totalCost = 0;

            Console.WriteLine("\nМесяц | Прогнозируемая стоимость (руб.)");

            for (int month = 1; month <= 10; month++)
            {
                currentPrice -= P;
                currentPrice += currentPrice * (q / 100);

                Console.WriteLine($"{month,5} | {currentPrice: F2}");

                totalCost += currentPrice;
            }

            double averageCost = totalCost / 10;

            Console.WriteLine($"\nСредняя стоимость продукта за 10 месяцев: {averageCost: F2} руб.");
        }
    }
}
