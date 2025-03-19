// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    int number1 = 10;
    int number2 = 0;
    int result = number1 / number2;
    Console.WriteLine("Result: " + result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("A Division by zero erroe accurred!");
    Console.WriteLine("Error message: " + ex.Message);
}
finally
{
    Console.WriteLine("The finally block is executed in all cases!");
}