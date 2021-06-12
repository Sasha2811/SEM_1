using System;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, f;
            Console.Write("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            f =((((2 * x - 3) * x + 4) * x - 5) * x + 6);
            Console.Write("F=");
            Console.WriteLine(f);  
        }
    }
}
