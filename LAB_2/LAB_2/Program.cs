using System;

namespace LAB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double u = 0;
            double D = 0;
            int a = 0;
            double x;
            string b;
            Console.WriteLine("Введите значение: ");

            do
            {
                b = Console.ReadLine();
                x = Convert.ToDouble(b);
                if (a > x)
                {
                    Console.WriteLine("Введите другое значение: ");
                }
            } while (a > x);

            for (int i = 0; i <= x; i++)
            {
                u += (Math.Pow(i, 2) + Math.Pow(-1, Math.Pow(i, 2) + Math.Pow(-1, i) * i) * i) / (3*Math.Pow(i, 2) + 5);
                D *= u;
                Console.WriteLine("u" + i + "=" + u);
                u = 0;
            }
            Console.WriteLine("Произведение = " + D);
        }
    }
}
    
