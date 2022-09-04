// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using ConsoleTables;

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

//3. Output the number of bytes in memory that each of the following number types uses and the minimum and maximum values they can have.
ConsoleTable table = new ConsoleTable("Type", "Minumum", "Maximum");
table.AddRow("sbyte", "-128", "127");
table.AddRow("byte", "0", "255");
table.AddRow("short", "-32768", "32767");
table.AddRow("ushort", "0", "65532");
table.AddRow("int", "-2147483648", "2147483647");
table.AddRow("uint", "0", "4294967295");
table.AddRow("long", "-9223372036854775", "9223372036854775807");
table.AddRow("ulong", "0", "18446744073709551615");
table.AddRow("float", "-3.4028235E+38", "3.4028235E+38");
table.AddRow("double", "-1.7976931348623157E+308", "1.7976931348623157E+308");
table.AddRow("decimal", "-79228162514264337593543950335", "79228162514264337593543950335");
Console.WriteLine(table);

//4. Create a 5 Function Calcaulator.
int function = 0;
while (function != 6)
{
    Console.WriteLine("Menu");
    Console.WriteLine("What function do you want to perform:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Modulus");
    Console.WriteLine("6. Exit");
    function = int.Parse(Console.ReadLine());

    switch (function)
    {
        case 1:
            Console.WriteLine("What two numbers do you want to add together?");
            Console.WriteLine("Please enter a number");
            int add1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int add2 = Int32.Parse(Console.ReadLine());
            int add3 = add1 + add2;
            Console.WriteLine("Your total is: " + add3);
            break;
        case 2:
            Console.WriteLine("What two numbers do you want to subtract?");
            Console.WriteLine("Please enter a number");
            int sub1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int sub2 = Int32.Parse(Console.ReadLine());
            int sub3 = sub1 - sub2;
            Console.WriteLine("Your total is: " + sub3);
            break;
        case 3:
            Console.WriteLine("What two numbers do you want to multiply?");
            Console.WriteLine("Please enter a number");
            int mult1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int mult2 = Int32.Parse(Console.ReadLine());
            int mult3 = mult1 * mult2;
            Console.WriteLine("Your total is: " + mult3);
            break;
        case 4:
            Console.WriteLine("What number do you want to divide?");
            Console.WriteLine("Please enter a number");
            int div1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number to divide by");
            int div2 = Int32.Parse(Console.ReadLine());
            int div3 = div1 / div2;
            Console.WriteLine("Your total is: " + div3);
            break;
        case 5:
            Console.WriteLine("What number do you want to find the remainder of?");
            Console.WriteLine("Please enter a number");
            int mod1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int mod2 = Int32.Parse(Console.ReadLine());
            int mod3 = mod1 % mod2;
            Console.WriteLine("Your total is: " + mod3);
            break;
        case 6:
            Console.WriteLine("Thank you for using our calculator.");
            break;
        default:
            Console.WriteLine("Thank you for using our calculator.");
            break;
    }
}
Console.WriteLine("Thank you for using this program");