using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//14.Резервуар содержит P кг летучего вещества. В начале каждых суток из него изымается T кг вещества. За сутки улетучивается q % вещества. Определить массу вещества в резервуаре на конец первых, вторых, ..., N-х суток. Предполагается, что Р >> NТ. Озеро содержит А км3 воды. Ежегодно объем воды уменьшается на р %. Если построить на берегу завод, то это при¬ведет к дополни¬тельному ежегодному уменьшению объема на В км3. Вычислить объем воды в озере через N лет при условии суще¬ствования завода

namespace _16Zadach
{
    internal class _14
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную массу вещества (P) в кг: ");
            double P = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите массу вещества, изымаемую за сутки (T) в кг: ");
            double T = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент улетучиваемого вещества за сутки (q): ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество суток (N): ");
            int N = int.Parse(Console.ReadLine());

            double currentMass = P;
            for (int i = 1; i <= N; i++)
            {
                currentMass -= T;
                currentMass -= currentMass * (q / 100);
                Console.WriteLine($"Масса вещества на конец {i}-ых суток: {currentMass} кг");
            }
            Console.WriteLine();

            Console.Write("Введите начальный объем воды в озере (A): ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Введите ежегодгный процент уменьшения объема воды (p): ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Введите дополнительное ежегодное уменьшение объема воды из-за завода (B): ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Введите количество лет (N): ");
            double N_lake = int.Parse(Console.ReadLine());

            double currentVolume = A;
            for (int i = 1; i <= N_lake; i++)
            {
                currentVolume -= currentVolume * (p / 100);
                currentVolume -= B;
                Console.WriteLine($"Объем воды в озере  через {i} лет: {currentVolume} км^3");
            }
        }
    }
}
