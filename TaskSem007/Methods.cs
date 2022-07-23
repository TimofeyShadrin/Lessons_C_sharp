namespace Seminar7
{
    class Methods
    {
        static public double[,] GetRandomDoubleArray(byte length, byte top)
        {
            double[,] randomArray = new double[length, top];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < top; j++)
                {
                    double temp = new Random().Next(-10, 11);
                    temp += new Random().Next(0, 11) / 10;
                    randomArray[i, j] = temp;
                }
            }
            return randomArray;
        }

        public static void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
