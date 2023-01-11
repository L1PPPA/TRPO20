using System;

namespace lab1v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X1= ");
            int x1 = int.Parse(Console.ReadLine());//запросить переменную х1
            Console.Write("X2= ");
            int x2 = int.Parse(Console.ReadLine());//запролсить переменную х2
            Console.Write("Y1= ");
            int y1 = int.Parse(Console.ReadLine());//запросить переменную y1
            Console.Write("Y2= ");
            int Y2 = int.Parse(Console.ReadLine());//запросить переменную y2


            int square = (x2 - x1) * (Y2 - y1);//вычислить площадь
            Console.WriteLine("Площадь равна {0}",square);//вывести ответ

            Console.ReadKey();
        }
    }
}
