// See https://aka.ms/new-console-template for more information
int num2 = 0;
Console.WriteLine("Please Enter Your First Number!");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Your Second Number!");

string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);


//Add Numbers
int sum = num1 + num2;

//Subtract Numbers
int subtract = num1 - num2;

//Multiply Numbers
int Multiply = num1 * num2;

//Divide Numbers
int  Divide = num1 / num2;

//Modulus Numbers
int modulus = num1 % num2;

Console.WriteLine("**************** Math Result******************");
Console.WriteLine();
Console.WriteLine($"Addition of Numbers : {sum}");
Console.WriteLine($"Subtraction of Numbers : {subtract}");
Console.WriteLine($"Multiplication of Numbers : {Multiply}");
Console.WriteLine($"Division of Numbers : {Divide}");
Console.WriteLine($"Modulus of Numbers : {modulus}");
Console.WriteLine();

Console.WriteLine("**************** Math Result******************");

Console.WriteLine();
Console.WriteLine("****************Logic Operators ******************");
Console.WriteLine();

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqual = num1 >= num2;
bool isLessThanOrEqual = num1 <= num2;
bool isNotEqualTo  = num1 != num2;

Console.WriteLine();
Console.WriteLine($"isGreaterThan : {isGreaterThan}");
Console.WriteLine($"isLessThan : {isLessThan}");
Console.WriteLine($"isEqualTo : {isEqualTo}");
Console.WriteLine($"isGreaterThanOrEqual : {isGreaterThanOrEqual}");
Console.WriteLine($"isLessThanOrEqual : {isLessThanOrEqual}");
Console.WriteLine($"isNotEqualTo : {isNotEqualTo}");
Console.WriteLine();
Console.WriteLine("****************Logic Operators ******************");
Console.WriteLine();

Console.WriteLine("****************Assignment Operations & Assignment ******************");

//  int randomValue = 7;
//  int increaseValue =num1+5;


