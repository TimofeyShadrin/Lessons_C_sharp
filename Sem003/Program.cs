namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
            // причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

            // Задача 2. Напишите программу, которая по заданному номеру четверти, 
            // показывает диапазон возможных координат точек в этой четверти (x и y). 

            // x = Convert.ToInt32(str[i].ToString());

            // int num1 = Int32.MinValue;
            // int num2 = Int32.MaxValue;
            // Console.ReadKey();

            // string[] nums = str.Split(' '); - создать массив из цифр введенных через к примеру пробел.

            // Напишите программу, которая принимает на вход число (N) и 
            // выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4


            //int x = Convert.ToInt32(Console.ReadLine().ToString());
            //int y = Convert.ToInt32(Console.ReadLine().ToString());

            Console.Clear();
            void Method1()
            {
                Console.WriteLine("Автор: Шадрин Т.И.");
            }
            Method1();

            void Method2(string msg)
            {
                Console.WriteLine(msg);
            }
            Method2(msg: "Test");

            void Method21(string msg, int count)
            {
                int i = 0;
                while (i < count)
                {
                    Console.WriteLine(msg);
                    i++;
                }
            }
            Method21(count: 4, msg: "New text");

            int Method3()
            {
                return DateTime.Now.Year;
            }
            int year = Method3();
            Console.WriteLine(year);

            string Method4(int count)
            {
                string result = String.Empty;

                for (int i = 2; i < count; i++)
                {
                    for (int j = 2; j < count; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                    Console.WriteLine();
                }
                return result;
            }
            string res = Method4(10);
            //Console.WriteLine(res);

            string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы Вас послали вместо нашего милого Винценгероде, "
            + "Вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

            // string s = "qwerty";
            //             012345
            // s[3] // r 

            string Replace(string text, char oldValue, char newValue)
            {
                string result = String.Empty; // инициализация пустой строки

                int length = text.Length;
                for (int i = 0; i < length; i++)
                {
                    if (text[i] == oldValue) result = result + $"{newValue}";
                    else result = result + $"{text[i]}";
                }

                return result;
            }

            string newText = Replace(text, ' ', '|');
            Console.WriteLine(newText);
            Console.WriteLine();
            newText = Replace(newText, 'к', 'К');
            Console.WriteLine(newText);

            int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
            void PrintArray(int[] array)
            {
                int count = array.Length;
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{array[i]} ");
                }

                Console.WriteLine();

            }

            PrintArray(arr);

            void SelectionSort(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int minPosition = i;

                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[minPosition]) minPosition = j;
                    }

                    int temporary = array[i];
                    array[i] = array[minPosition];
                    array[minPosition] = temporary;
                }
            }

            SelectionSort(arr);
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine($"NewLine: {Environment.NewLine}  first line {Environment.NewLine}  second line");
        }

    }
}
