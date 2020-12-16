using System;

namespace лаб_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            const int n = 10;
            int[] a = new int[n];
            Console.WriteLine("Массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                a.SetValue(r.Next(-20, 20), i);
                Console.Write(" " + a.GetValue(i));

            }
            Console.WriteLine();
            // ошибка при присваивании максимального элемента
            double max = double.MinValue;
            double min = double.MaxValue;

            for (int i = 0; i < a.Length; i++)

                if (a[i] < 0 && a[i] > max)
                    max = a[i];


            for (int i = 0; i < a.Length; i++)

                if (a[i] > 0 && a[i] < min)
                    min = a[i];

            Console.WriteLine("Минимальное среди положительных: " + min, "\n");
            Console.WriteLine("Максимальное среди отрицательных: " + max, "\n");
            Console.ReadKey();
        }
    }
}