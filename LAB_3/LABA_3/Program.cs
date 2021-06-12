using System;

namespace LABA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Вы ввели такое число: ");
            Console.WriteLine(num);
            if (num >= 100)
            {

                if (num / 100 + num % 10 == 2 * (num / 10) % 10)
                    Console.Write("Правильное");

                else
                    Console.Write("Неправильно");

            }
            else
            Console.Write("Неправильное число, введите трехзначное число!!!");
            Console.ReadLine();
        }
    }
}

