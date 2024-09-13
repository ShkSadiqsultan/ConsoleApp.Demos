// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Xml.Linq;

string fname = string.Empty;
string lname = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;


Console.WriteLine("Please Enter Your First Name");
fname = Console.ReadLine();

Console.WriteLine("Please Enter Your Last Name");
lname = Console.ReadLine();

Console.WriteLine("Please Enter Your Age");
age= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Your Gender (M or F)");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Please Enter Your Salary");
salary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Your Working Status (True or False)");
working = Convert.ToBoolean(Console.ReadLine());

int wordkingYearsRemaining = retirementAge - age;

Console.WriteLine($"My First Name is :  {fname}");
Console.WriteLine($"My Last Name is :  {lname}");
Console.WriteLine($"My Age is : { age}");
Console.WriteLine($"My Gender is : {gender}");
Console.WriteLine($"My Salary is : {salary}");
Console.WriteLine($"My Working Status : {working}");
Console.WriteLine($"My Numbers of Remaining Years : {wordkingYearsRemaining}");