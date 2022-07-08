// 1. Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

// Размер массива от 5 до 10
// Числа в массива от -20 до 20



namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] digits = GetRandomArray(5, 11, -20, 20);
            PrintGotArray(digits);
            Console.WriteLine();
            GetPositiveToNegativeArray(digits);
            PrintGotArray(digits);
            Console.WriteLine();
        }

        static int[] GetRandomArray(byte minSize, byte maxSize, int MinValue, int MaxValue)
        {
            int[] array = new int[0];
            int arrayLength = new Random().Next(minSize, maxSize);
            Array.Resize(ref array, arrayLength);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(MinValue, MaxValue);
            }
            return array;
        }

        static int[] GetPositiveToNegativeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0 - array[i];
            }
            return array;
        }

        static void PrintGotArray(int[] numbers)
        {
            if (numbers.Length >= 3)
            {
                Console.Write($"[{numbers[0]},");
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    Console.Write($" {numbers[i]},");
                }
                Console.WriteLine($" {numbers[numbers.Length - 1]}]");
            }
            else if (numbers.Length == 2)
            {
                Console.WriteLine($"[{numbers[0]}, {numbers[1]}]");
            }
            else if (numbers.Length == 1)
            {
                Console.WriteLine($"[{numbers[0]}]");
            }
            else
            {
                Console.WriteLine("Sorry, but the pc didnt create an array.");
            }
        }
    }
}
