using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//13. 1 кВт электроэнергии стоит R руб. Прогнозируется ежегодное увели¬чение этой стоимости на р %. Определить годовую плату сред¬ней семьи за электроэнергию (при потреблении 3000 кВт в год) че¬рез 1, 2, ..., N лет. В первый год стоимость электроэнергии растет на р %, затем эта ве¬личина (рост стоимости в процентах) снижается еже¬годно на 0,5 %.

namespace _16Zadach
{
    internal class _13
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1 кВт электроэнергии (R): ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент увеличения стоимости (p): ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество лет (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            double annualConsumption = 3000;

            Console.WriteLine("\nГод | Стоимость 1 кВт  (руб.) | Годовая плата (руб.) ");

            double currentPrice = R;
            double currentIncreasePercentage = p;

            for (int year = 1; year <= N; year++)
            {
                double annualPayment = currentPrice * annualConsumption;

                Console.WriteLine($"{year,3} | {currentPrice,22: F2} | {annualPayment,18: F2}");

                currentPrice *= (1 + currentIncreasePercentage / 100);
                currentIncreasePercentage -= 0.5;
            }
        }
    }
}
