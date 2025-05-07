using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. 1 кВт электроэнергии стоит R руб.Прогнозируется ежегодное увели¬чение этой стоимости на р %. Определить годовую плату сред¬ней семьи за электроэнергию(при потреблении 3000 кВт в год) че¬рез 1, 2, ..., N лет.

namespace _16Zadach
{
    internal class _2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1 кВт электроэнергии (R) в рублях: ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежегодное увеличение стоимости (p) в процентах: ");
            double p = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Введите количество лет (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            const double annualConsumption = 3000;

            double[] annualPayments = new double[N];

            for (int i = 0; i < N; i++)
            {
                double currentCost = R * Math.Pow(1 + p, i);
                annualPayments[i] = currentCost * annualConsumption;

                Console.WriteLine($"Годовая плата за электроэнергию через {i + 1} год(а): {annualPayments[i]: F2} руб.");

                double averagePayment = CalculateAverage(annualPayments);
                Console.WriteLine($"Средняя годовая плата за электроэнергию за {N} лет: {averagePayment: F2} руб");
            }
        }

        static double CalculateAverage(double[] payments)
        {
            double sum = 0;
            foreach (var payment in payments)
            {
                sum += payment;
            }
            return sum / payments.Length;
        }
    }
}
