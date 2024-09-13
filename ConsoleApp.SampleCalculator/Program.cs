// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Calculator!");
Console.WriteLine("Please inupt 1st Number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input 2nd Number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Select Your Option");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    //Addition
}
else if (choice == 2)
{
    //Subtraction
}
else if (choice == 3)
{
    //Multiplication
}
else if (choice == 4)
{
    //Division
}
else
{
    Console.WriteLine("InValid Input");
}
int answer = 0;
switch (choice)
{
    case 1:
            answer = num1 + num2;
        break;
    case 2:
        answer = num1 - num2;
        break;
    case 3:
        answer = num1 * num2;
        break;
    case 4:
        answer = num1 / num2;
        break;
    default:
        Console.WriteLine("InValid Input");
       
        break;
}
Console.WriteLine($"The Result is : {answer}"); 