using System;

namespace part3
{
    class Program
    {
        static int[] ArrayBiggerOnOne(int [] array)
        {
            int[] tempArray = new int[array.Length + 1];
            array.CopyTo(tempArray, 0);
            return tempArray;
        }
        static int[] ArrayAddNewFirstElement(int [] array, int value) 
        {
            int[] tempArray = new int[array.Length + 1];
            tempArray[0] = value;
            array.CopyTo(tempArray, 1);
            return tempArray;
        }
        static void ArrayPrint(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
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
            Console.WriteLine($"Natural array: ");
            ArrayPrint(Array);
            Console.WriteLine($"first method: ");
            ArrayPrint(ArrayBiggerOnOne(Array));
            Console.Write("Please, enter value: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine($"Second method:");
            ArrayPrint(ArrayAddNewFirstElement(Array, value));
            
            Console.ReadKey();
        }
    }
}
