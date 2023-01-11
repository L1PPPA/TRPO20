using System;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());//запросить переменную а
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());//запросить переменную b

            Console.WriteLine("{0} + {1} = {1} + {0}", a, b);//вывести результат

        }
    }
}
