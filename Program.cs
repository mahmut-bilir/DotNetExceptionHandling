﻿// See https://aka.ms/new-console-template for more information
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

Console.WriteLine("Throw example:");

try
{
    int age = 10;
    CheckAge(age);

}
catch (Exception ex)
{
    Console.WriteLine("Error caught:" + ex.Message);
}

void CheckAge(int age)
{
    if (age < 18)
    {
        throw new Exception("Age cannot be less than 18!");
    }
    Console.WriteLine("Age Applies");
}

Console.WriteLine("Custom exception example: ");

try
{
    UserRegister(15);
}
catch (Exception ex)
{
    Console.WriteLine("Custom error:" + ex.Message);
}

void UserRegister(int age)
{
    if (age < 18)
    {
        throw new AgeInvalidException("Age cannot be under 18! Registration failed.");
    }
    Console.WriteLine("User registered successfully!");
}