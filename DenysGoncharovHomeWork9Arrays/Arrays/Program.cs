using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колчество элемментов массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] Array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите {i + 1} -й элеммент массива: ");
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Поздравляю, Вы ввели {N} элементов массива");
            { 
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += Array[i];
            }
                Console.WriteLine($"сумма всех элементов массва {sum}");
            Console.WriteLine($"Средее аарифметическое элементов масивабудет равно {sum / N}");
            }//среднее арифмитическое
            {
                int max = Int32.MinValue;

                for (int i = 0; i < N; i++)
                {
                    if (Array[i] > max)
                    {
                        max = Array[i];
                    }
                }
                Console.WriteLine($"Maximum = {max}");
            }//maximum
        }
    }
}
