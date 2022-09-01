// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

// 1. Printting the output of adding two number from the user input.
Console.WriteLine("What two numbers do you want to add together?");
Console.WriteLine("Please enter a number");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter a number");
int num2 = Int32.Parse(Console.ReadLine());
int total = num1 + num2;
Console.WriteLine("Your total is: " + total);

// 2. Take a user's input number and input its multiplication table.
Console.WriteLine("Enter the number you want a multiplication table for.");
int num3 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter how high you want it to multiply by.");
int num4 = int.Parse(Console.ReadLine());
int product;

Console.WriteLine("\nMultiplication table for {0}: ", num3);
for (int i = 1; i <= num4; i++)
{
    product = num3 * i;
    Console.WriteLine("{0} x {1} = {2}", num3, i, product);
}

            