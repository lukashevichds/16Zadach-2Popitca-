using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3. Резервуар содержит P кг летучего вещества.В начале каждых суток из него изымается T кг вещества.За сутки улетучивается q % вещества.Определить массу вещества в резервуаре на конец первых, вторых, ..., N-х суток. Предполагается, что Р >> NТ.

namespace _16Zadach
{
    internal class _3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную массу вещества (P) в кг: ");
            double P = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество вещества, изымаемого за сутки (T) в кг: ");
            double T = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент улетучивания (q) в процентах: ");
            double q = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Введите количество суток (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            double[] masses = new double[N];

            for (int day = 0; day < N; day++)
            {
                P = P * (1 - q);
                P -= T;

                if (P < 0)
                {
                    P = 0;
                }

                masses[day] = P;
                Console.WriteLine($"Масса вещества в резервуаре на конец {day + 1}-го суток: {masses[day]: F2} кг");
            }
        }
    }
}
