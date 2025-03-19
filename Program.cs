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

Console.WriteLine("------------");

try
{
    int[] array = { 1, 4, 7, 2, 5, 8 };
    Console.WriteLine(array[10]);

}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Array boundaries reached!");
    Console.WriteLine("Error:" + e.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An unknown error accured: " + ex.Message);
}