﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please Enter Day of The Week!");

int dayofWeek = Convert.ToInt32(Console.ReadLine());
switch (dayofWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursady");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break; 
        default:
        Console.WriteLine("In-Valid DayNumber Entered");
        break;
}