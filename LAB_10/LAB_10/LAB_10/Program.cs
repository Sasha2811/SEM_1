using System;

namespace LAB_10
{
    class WorkWithArray
    {
     
        public string ArrayParams(params double[] array)
        {
            double max = array[0];
            double min = array[0];
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
                sum += array[i];
            }
            double average = sum / array.Length;

            return string.Format("Характеристики массива:\n" +
                    $"  - максимальное значение: {max:.##}\n" +
                    $"  - минимальное значение: {min:.##}\n" +
                    $"  - среднее значение: {average:.##}\n");
        }
    }

    class Program
    {
        static void Main()
        {
            WorkWithArray array = new WorkWithArray();

            int[] array1 = { 2, -10, 7, 15, 6, 24, 0 };
            double[] array2 = { 3.0, -22.5, 10, 19.1, -6.6, 14.0, 1.0 };
            Console.WriteLine(array.ArrayParams(array2));

            Console.ReadKey();
        }
    }
}