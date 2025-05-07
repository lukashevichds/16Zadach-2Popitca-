using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. Средняя урожайность пшеницы – P ц/га, урожайность ржи – T ц/га.Общая площадь угодий составляет C га.В первый год эта площадь делится поровну между пшеницей и рожью. В последующие годы площадь, засеваемая рожью, увеличивается на р % (за счет пше¬ницы). Определить ежегодные урожай пшеницы и урожай ржи в первые N лет

namespace _16Zadach
{
    internal class _5
    {
        static void Main(string[] args)
        {
            Console.Write("Введите среднюю урожайность пшеницы (ц/га): ");
            double P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите среднюю урожайность ржи (ц/га): ");
            double T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите общую площадь угодий (га): ");
            double С = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процент увеличения площади под рожью (r): ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество лет (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            double areaWheat = С / 2;
            double areaRye = С / 2;

            Console.WriteLine("\nГод\tУрожай пшеницы (ц) \tУрожай ржи (ц)");

            for (int year = 1; year <= N; year++)
            {
                double yieldWheat = areaWheat * P;
                double yieldRye = areaWheat * P;

                Console.WriteLine($"{year}\t{yieldWheat: F2} \t\t\t{yieldRye: F2}");

                areaRye *= (1 + r / 100);
                areaRye = С - areaRye;
            }
        }
    }
}
