namespace Seminar9
{
    // Задача 1. Из двумерного массива целых чисел удалить строку и столбец,
    // на пересечении которых расположен наименьший элемент.

    // Задача 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
    // и замените эти элементы на их квадраты
    // Например, изначально массив выглядел вот так:

    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4

    // Новый массив будет выглядеть вот так:

    // 1 4 7 2
    // 5 81 2 9
    // 8 4 2 4

    class Program
    {
        public static void Main(string[] args)
        {
            int[,] digits = Decision.CreateArray();
            Decision.PrintCurrentArray(digits);
            Console.WriteLine();
            Decision.SquareEvenNumbers(digits);
            Decision.PrintCurrentArray(digits);
            Console.WriteLine();
            NewArray.IndexOfMinElement(digits);
            Console.WriteLine($"{NewArray.height}, {NewArray.length}");
            int[,] numbers = NewArray.ArrayResize(digits);
            Decision.PrintCurrentArray(numbers);
        }
    }

    class Decision
    {
        public static int[,] CreateArray()
        {
            int height = new Random().Next(4, 4);
            int length = new Random().Next(4, 4);
            int[,] array = new int[height, length];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
            return array;
        }

        private static int FindMaxSize(int[,] incomingArray)
        {
            int MaxSizeOfElement = 0;
            for (int i = 0; i < incomingArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomingArray.GetLength(1); j++)
                {
                    string temp = incomingArray[i, j].ToString();
                    if (temp.Length > MaxSizeOfElement)
                        MaxSizeOfElement = temp.Length;
                }
            }
            return MaxSizeOfElement;
        }

        private static string QuantityWhitespaces(string elementOfArray, int MaxSizeOfElement)
        {
            string whitespaces = string.Empty;
            int diffOfLength = MaxSizeOfElement - elementOfArray.Length;
            for (byte i = 0; i < diffOfLength; i++)
            {
                whitespaces += " ";
            }
            return whitespaces;
        }

        public static void PrintCurrentArray(int[,] incomingArray)
        {
            int MaxSizeOfElement = FindMaxSize(incomingArray);
            for (int i = 0; i < incomingArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < incomingArray.GetLength(1); j++)
                {
                    string whitespaces = QuantityWhitespaces(
                        incomingArray[i, j].ToString(),
                        MaxSizeOfElement
                    );
                    Console.Write($"{whitespaces}{incomingArray[i, j].ToString()} ");
                }
            }
        }

        public static void SquareEvenNumbers(int[,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        numbers[i, j] = numbers[i, j] * numbers[i, j];
                    }
                }
            }
        }
    }
}
