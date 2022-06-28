// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

// Напишите программу, которая будет принимать на вход два числа и 
// выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, 
// то программа выводит остаток от деления. 34, 5 -> не кратно, 
// остаток 4 16, 4 -> кратно 

namespace HelloWorld 
{ class Program 
    { static void Main(string[] args) 
        { 
            int number = new Random().Next(10, 100); 
            string str = number.ToString(); 

            int x  = Convert.ToInt32(str[0].ToString());
            Console.WriteLine(number);

            for (int i = 0; i < str.Length; i++)
            {
                if (x < Convert.ToInt32(str[i].ToString()))
                {
                    x = Convert.ToInt32(str[i].ToString()); 
                }
            }

            Console.WriteLine($"x is: {x}");
            char[] test_number = str.ToString().ToCharArray();
            char y = str.ToString().ToCharArray().LastOrDefault();
            Console.WriteLine(test_number[0] + y.ToString());
        } 
    } 
} 
/*
amespace HelloWorld { 
    class Program { 
    // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
    static void Main(string[] args) 
    { 
        int number = new Random().Next(100, 1000); 
        Console.WriteLine(number); 
        string str = number.ToString(); 
        //Console.WriteLine(str); 
        char n0 = str[0]; 
        //Console.WriteLine(n0); 
        char n2 = str[2]; 
        //Console.WriteLine(n2); 
        string result = n0.ToString() + n2.ToString(); 
        Console.WriteLine(result); 
        } 
    } 
} 
*/