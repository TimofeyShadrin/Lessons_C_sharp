namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            Console.WriteLine("Input value: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Получаем число
            int square = Convert.ToInt32(Math.Pow(number, 2));
            // Или получаем и записваем число
            number *= number;
            // Вывод результата
            Console.WriteLine($"Square is: {square}");

        } 
    } 
} 

// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго. 

// 2. Напишите программу, которая будет выдавать название дня недели
//  по заданному номеру.