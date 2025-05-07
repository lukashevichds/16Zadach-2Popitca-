using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 6.	Длина шоссейных дорог области равна D км. Прогнозируется еже¬годный ее прирост на B км. Полагается, что на каждые C км дорог необходим один пост автоинспекции. Для текущего года и после¬дующих N лет найти необходимое число постов автоинспекции

namespace _16Zadach
{
    internal class _6
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину шоссейных дорог (D) в км: ");
            double D = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ежегодный прирост дорог (B) в км: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество км дорог на один пост автоинспекции (C): ");
            double C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество лет (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nГод \tДлина дорог(км) \tКоличество постов");

            for (int year = 0; year <= N; year++)
            {
                double currentLength = D + (B * year);

                int numberOfPosts = (int)Math.Ceiling(currentLength / C);

                Console.WriteLine($"{year}\t {currentLength: F2}\t\t{numberOfPosts}");
            }
        }
    }
}
