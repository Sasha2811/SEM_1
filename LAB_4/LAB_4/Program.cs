using System;

namespace LAB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int lenthOfArray = int.Parse(Console.ReadLine());//переменная длины массива
            //Console.WriteLine(lenthOfArray);//считываем длину массива
            int[] Array = new int[lenthOfArray];
            int M = 1;
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"Введите елемент массива под индексом {i}:\t");
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Вывод массива:\n");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);//считываем массив
            }
            for (int i = 0; i < Array.Length; i++)
            {
            
            if (i > 1)
                    if ((Array[i] > Array[i - 1]) && (Array[i - 1] < Array[i - 2]))
                    {
                        M++;
                    }
                    else
                    {
                        if ((Array[i] < Array[i - 1]) && (Array[i - 1] > Array[i - 2]))
                            M++;
                        else
                        if ((Array[i] == Array[i - 1]) && (Array[i - 1] != Array[i - 2]))
                            M++;
                    }
            }
            Console.WriteLine("Количество промежутков монотонности: " + M);
        }

    }
}


