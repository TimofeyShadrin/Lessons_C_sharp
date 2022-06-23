int count = 0;

Console.Write("How is your name? ");
string? name = Console.ReadLine();
if (name != null)
{
name = name.ToLower();
}

if (name == "timofei")
{
    Console.WriteLine("Hi, Tim!");
}
else if (name == "timofey")
{
    Console.WriteLine("Hi? Tim!");
}
else if (name == "tim")
{
    Console.WriteLine("Hi? Tim!");
}
else
{
    Console.WriteLine("Hello, my freind!");
}

Console.Write("What is the speed of the freind number one? ");
int firstFreindSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the speed of the freind number second? ");
int secondFreindSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the speed of the dog? ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());
int freind = 2;
float distance = new Random().Next(20, 100);
Console.WriteLine("Distance = " + distance);
float time = 0;

while (distance > 2)
{
    if (freind == 1)
    {
        time = distance / (firstFreindSpeed + dogSpeed);
        freind = 2; 
    }

    if (freind == 2)
    
    {
        time = distance / (dogSpeed + secondFreindSpeed);
        freind = 1;
    }

    distance = distance - (firstFreindSpeed + secondFreindSpeed) * time;
    count = count + 1;
}

Console.WriteLine("Dog run " + count + " times");