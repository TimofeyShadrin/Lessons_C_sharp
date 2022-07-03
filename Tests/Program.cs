namespace HelloWorld
{
    class Program
    {
        static void PrintArrayInt(int[] array, int i)
        {
            Console.Write($"{array[i]} ");
            if (i >= array.Length - 1) return;
            else
            {
                i++;
                PrintArrayInt(array, i);
            }
        }

        static int Sum(int[] array, int i)
        {
            int sum = array[i];
            i++;
            if (i < array.Length) return sum + Sum(array, i);
            else return sum;
        }

        static int Str(string text, int i)
        {
            int sum = Convert.ToInt32(text[i].ToString());
            i++;
            if (i < text.Length) return sum + Str(text, i);
            else return sum;
        }

        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            PrintArrayInt(numbers, 0);
            Console.WriteLine();
            Console.WriteLine(Sum(numbers, 0));
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) Console.WriteLine(Str(input, 0));

        }

    }
}