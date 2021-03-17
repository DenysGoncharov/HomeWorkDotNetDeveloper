using System;

namespace ArrayMethods
{
    class Program
    {
        /// <summary>
        /// принимает в качестве аргумента массивцелочисленных элементов и 
        /// возвращает инвертированный массив(элементы массива в обратном порядке).
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] MyReverse(int[] array)
        {
            int[] intermediateArrray = new int[array.Length];
            for (int i = 0; i < array.Length-1; i++)
            {
                intermediateArrray[array.Length] = array[i];
            }
            return intermediateArrray;
        }
        /// <summary>
        /// Метод возвращает часть полученного в качестве аргумента массива,
        /// начиная с позиции указанной в аргументе index,размерностью,
        /// которая соответствует значению аргумента count.
        /// Если аргумент count содержит значение больше чем количество элементов,
        /// которые входят в выбираемую часть исходного массива 
        /// (от указанного индекса index, до индекса последнего элемента),
        /// то при формировании нового массива размерностью в count, заполните единицами те элементы,
        /// которые не были скопированы из исходного массива.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns>subArray[count]</returns>
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            int j = 0;


            for (int i = index; i < count; i++)
            {
                if (count < array.Length)
                {
                    subArray[j] = array[i];
                }
                else
                {
                    subArray[j] = 1;
                }
                j++;
            }

            return subArray;
        }
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

            Console.WriteLine("Проверка первого метода");
            Console.WriteLine($"{MyReverse(Array)}");
            Console.WriteLine("Проверка второго метода");
            Console.Write("Введие размер нового массива: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Введие индекс элемента с кторого нужно вывести массив");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"{SubArray(Array, index, count)}");
            //Delay
            Console.ReadKey();
        }
    }
}
