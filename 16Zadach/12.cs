using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12.Розничная цена товара составляет C руб. за 1 кг, оптовая—на р % ниже. Вывести стоимость 5, 10, 15, ..., 50 кг товара по розничной и оптовой цене в рублях и долларах (текущий курс доллара равен D руб.). При увеличении количества товара на 5 кг оптовая цена за 1 кг уменьша¬ется на р % (для 5 кг товара она равна розничной цене). 

namespace _16Zadach
{
    internal class _12
    {
        static void Main(string[] args)
        {
            Console.Write("Введите розничную цену товара C (в рублях за 1 кг): ");
            double C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент p (на сколько ниже оптовая цена): ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите текущий курс доллара D (в рублях): ");
            double D = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nКоличество (кг) | Розничная цена (руб.)| Оптовая цена (руб.)| Розничная цена (долл.)| Оптовая цена (долл.)");

            double wholesalePrice = C * (1 - p / 100);
            double totalRetailPrice;
            double totalWholeSalePrice;

            for (int kg = 5; kg <= 50; kg += 5)
            {
                totalRetailPrice = kg * C;
                totalWholeSalePrice = kg * wholesalePrice;

                double retaiPriceInDollars = totalRetailPrice / D;
                double wholesalePriceInDollars = totalWholeSalePrice / D;

                Console.WriteLine($"{kg,15} | {totalRetailPrice,20:F2} | {totalWholeSalePrice,20: F2} | {retaiPriceInDollars,24: F2} | {wholesalePriceInDollars,24: F2}");

                wholesalePrice *= (1 - p / 100);
            }
        }
    }
}
