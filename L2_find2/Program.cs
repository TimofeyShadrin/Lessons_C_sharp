void FillArray(int[] collection) // метод для заполнения массива
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        //collection[index] = new Random().Next(1, 10);
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }

}

void PrintArray(int[] col) // выводим массив в консоль в виде [1, 2, 3, 4, 5, 6, 7, 8, 9]
{
    int count = col.Length;
    int position = 0;
    
    Console.Write($"[{col[0]},");

    while (position + 1 < count - 1)
    {
        Console.Write($" {col[position]},");
        position++;
    }

    Console.WriteLine($" {col[position]}]");
}

int indexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // метод возвращает это значение по договоренности программистов, если искомого элемента нет в наличии.

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

return position;
}

int[] array = new int[10]; // конструкция обозначает дословно - создай новый массив в котором будет 10 элементов

Console.Clear();

FillArray(array);

Console.Clear();
//array[4] = 4;
//array[7] = 4;

PrintArray(array);

Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);
