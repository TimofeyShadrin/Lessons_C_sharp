namespace Seminar7
{
    class Main
    {
        public static void Main(string[] args)
        {
            double[,] numbers = Methods.GetRandomDoubleArray(4, 3);
            Methods.PrintArray(numbers);
        }
    }
}
