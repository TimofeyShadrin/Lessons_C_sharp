void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
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

FillArray(array);

array[4] = 4;
array[7] = 4;

PrintArray(array);

Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);
