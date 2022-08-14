void IfWeekend(int day)
{
    if(day/6 >= 1) 
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}

int day = 6;
IfWeekend(day);
day = 7;
IfWeekend(day);
day = 1;
IfWeekend(day);