// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1. Printting the output of adding two number from the user input.
Console.WriteLine("What two numbers do you want to add together?");
Console.WriteLine("Please enter a number");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter a number");
int num2 = Int32.Parse(Console.ReadLine());
int total = num1 + num2;
Console.WriteLine("Your total is: " + total);
/////