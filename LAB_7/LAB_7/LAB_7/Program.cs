using System;
using System.Collections.Generic;
using System.Linq;

namespace LABA_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> chList = new List<char>();
            Console.WriteLine("Вводите символы (Стоп - Enter): ");
            ConsoleKey n;
            while ((n = Console.ReadKey(true).Key) != ConsoleKey.Enter)
            {
                chList.Add((char)n);
                Console.Write(n.ToString().ToLower() + " ");
            }
            Console.WriteLine();
            Console.Write("Введите символ, чтоб узнать его индекс: ");
            char ch = (char)Console.ReadKey().Key;
            Console.WriteLine();
            Console.WriteLine("Индекс символа: ");
            for (int i = 0; i < chList.Count; i++) 
                if (chList[i] == ch)
                Console.Write(i + " ");
            char[] arr = chList.ToArray();
            Console.ReadKey(true);
        }
    }
}