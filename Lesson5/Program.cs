// string[,] table = new string[2, 5];
// table[1, 2] = "word";

// //String.Empty

// // for (int rows = 0; rows < 2; rows++)
// // {
// //     for (int cols = 0; cols < 5; cols++)
// //     {
// //         Console.WriteLine($"-{table[rows, cols]}-");
// //     }

// // }
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);



namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 40; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        public static double Fibonacci(int n)
        {
            if (n <= 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
