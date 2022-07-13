namespace Seminar6
{
    class Program
    {
        static void Main(string[] args)
        {
            // string? str = Console.ReadLine();
            // if (str != null && str.Length > 0)

            // int num = Convert.ToInt32(str);

            // try
            // {
            //     string? str = Console.ReadLine();
            //     int num = Convert.ToInt32(str);
            //     //throw new Exception(); // проверка на ошибку, чтобы проверить что будет в catch
            // }
            // catch 
            // {
                   
            // }

            // 1. Напишите программу, которая перевернёт одномерный массив 
            // (последний элемент будет на первом месте, а первый - на последнем и т.д.)

            // [1 2 3 4 5] -> [5 4 3 2 1]

            // [6 7 3 6] -> [6 3 7 6]

            // 2. Напишите программу, которая будет создавать копию 
            // заданного массива с помощью поэлементного копирования.

            int[] array = new int[0];

            void FillArray(ref int[] mass, int sizeOfArray, int minSize, int maxSize)
            {
                
                Array.Resize(ref mass, sizeOfArray);
                for (int i = 0; i < sizeOfArray; i++)
                {
                    mass[i] = new Random().Next(minSize, maxSize);
                }
            }

        }
    }
}
