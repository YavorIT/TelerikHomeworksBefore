﻿
/*
                    Problem 1. Square root

    Write a program that reads an integer number and calculates and prints its square root.
    If the number is invalid or negative, print Invalid number.
    In all cases finally print Good bye.

    Use try-catch-finally block.
*/

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter the integer: ");
        uint number;

        double result;
        try
        {
            number = uint.Parse (Console.ReadLine());
            result = Math.Sqrt(number);
            Console.WriteLine(result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number.");
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid number.");
        }
        finally
        {
            Console.WriteLine("Good Bye.");
        }
    }
}