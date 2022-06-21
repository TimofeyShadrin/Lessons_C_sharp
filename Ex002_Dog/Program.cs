int count = 0;
int firstFreindSpeed = 2;
int secondFreindSpeed = 1;
int dogSpeed = 5;
int freind = 2;
int distance = 50;
int time = 0;

while (distance > 2)
{
    if (freind == 1)
    {
        time = distance / (firstFreindSpeed + dogSpeed);
        freind = 2; 
    }

    if (freind == 2)
    //else
    {
        time = distance / (dogSpeed + secondFreindSpeed);
        freind = 1;
    }

    distance = distance - (firstFreindSpeed + secondFreindSpeed) * time;
    count = count + 1;
}

Console.WriteLine(count);