using System;

namespace lab1v3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int num = int.Parse(Console.ReadLine());//запросить число
            int n1 = num / 100;//вычислить первую цифру числа
            int n2 = num / 10 % 10;//вычислить вторую цифру числа
            int n3 = num % 10;//вычислить третью цифру числа

            int ans = (n1 < n2) ? n1 : n2;//найти минимальную цифру из первых двух
            ans = (ans < n3) ? ans : n3;//найти минимальную цифру из трёх
            
            Console.WriteLine("Минимальная цифра в числе {0} - {1}", num, ans);//вывести ответ


        }
    }
}
