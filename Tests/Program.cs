namespace HelloWorld
{
    class Program
    {
        static void PrintArrayInt(int[] array, int i = 0)
        {
            if (i < array.Length)
            {
                Console.Write($"{array[i]} ");
                PrintArrayInt(array, i + 1);
            }
        }

        // static int Sum(int[] array, int i = 0)
        // {
        //     int sum = array[i];
        //     i++;
        //     if (i < array.Length) return sum + Sum(array, i);
        //     else return sum;
        // }
        static int Sum(int[] array, int i = 0)
        {
            if (i >= array.Length) return 0;
            int result = Sum(array, i + 1); // рекурсия сначала создает стэки с заполненными функциями,
                                            // а потом при доставании их тз него делает действия в обратном порядка,
                                            // начиная с i = array.Length - 1
            return result + array[i];
        }


        static int Str(string text, int i = 0)
        {
            int sum = Convert.ToInt32(text[i].ToString());
            i++;
            if (i < text.Length) return sum + Str(text, i);
            else return sum;
        }

        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            PrintArrayInt(numbers);
            Console.WriteLine();
            Console.WriteLine(Sum(numbers));
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) Console.WriteLine(Str(input));

        }

    }
}