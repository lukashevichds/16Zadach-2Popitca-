using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1.	Розничная цена товара составляет C руб. за 1 кг, оптовая—на р % ниже. Вывести стоимость 5, 10, 15, ..., 50 кг товара по розничной и оптовой цене в рублях и долларах (текущий курс доллара равен D руб.)

namespace _16Zadach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите розничную цену (C) за 1 кг: ");
            double C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент (p) снижения оптовой цены: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите текущий курс доллара(D): ");
            double D = Convert.ToDouble(Console.ReadLine());

            double wholesalePrice = C * (1 - p / 100);

            Console.WriteLine("\nКоличесвто (кг) \tРозничная цена (руб) \tОптовая цена (руб) \tРозничная цена ($) \tОптовая цена ($)");

            for (int kg = 5; kg <= 50; kg += 5)
            {
                double retailCost = C * kg;
                double wholesaleCost = wholesalePrice * kg;

                double retailCostInDollars = retailCost / D;
                double wholesaleCostInDollars = wholesaleCost / D;

                Console.WriteLine($"{kg} \t\t{retailCost: F2} \t\t\t{retailCostInDollars: F2} \t\t\t{wholesaleCostInDollars: F2}");
            }
        }
    }
}
