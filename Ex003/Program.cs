Console.Clear();
int[] numbers = new int[5];

foreach (int i in numbers)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int j in numbers)
{
    Console.Write($"{numbers[j]} \t");
}