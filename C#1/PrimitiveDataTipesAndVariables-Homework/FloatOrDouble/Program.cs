
/*
 			 Problem 2. Float or Double?

	Which of the following values can be assigned to a variable of type float
	and which to a variable of type double:
	34.567839023, 12.345, 8923.1234857, 3456.091?
	Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

using System;

class FloatOrDouble
{
	public static void Main ()
	{
		double firstNumber = 34.567839023;
		float secondNumber = 12.345F;
		double thirdNumber = 8923.1234857;
		float lastNumber = 3456.091F;

		Console.WriteLine ("The numbers are:");
		Console.WriteLine (firstNumber + "\n" + secondNumber + "\n" + thirdNumber + "\n" + lastNumber);
	}
}