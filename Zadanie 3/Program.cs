using System;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вероятность отказа 1 детали");
            Double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вероятность отказа 2 детали");
            Double n = Convert.ToDouble(Console.ReadLine());
            Double q1 = 1 - p;
            Double q2 = 1 - n;
            Double P = 1 - q1 * q2;
            P = Math.Round(P,2);
            Console.WriteLine($"Ответ:{P}%");
            Console.ReadKey();

        }
    }
}
