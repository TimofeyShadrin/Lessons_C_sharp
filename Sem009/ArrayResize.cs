namespace Seminar9
{
    // Задача 1. Из двумерного массива целых чисел удалить строку и столбец,
    // на пересечении которых расположен наименьший элемент.
    class NewArray
    {
        public static int height;
        public static int length;

        public static void IndexOfMinElement(int[,] array)
        {
            int minElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                        height = i;
                        length = j;
                    }
                }
            }
        }

        public static int[,] ArrayResize(int[,] array)
        {
            int[,] numbers = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            for (int i = 0, k = 0; i < array.GetLength(0) && k < numbers.GetLength(0); i++, k++)
            {
                if (i == height)
                    i++;
                for (int j = 0, l = 0; j < array.GetLength(1) && l < numbers.GetLength(1); j++, l++)
                {
                    if (l == length)
                        j++;
                    numbers[k, l] = array[i, j];
                }
            }
            return numbers;
        }
    }
}
