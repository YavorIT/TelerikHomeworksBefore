
/*
					Problem 3. Divide by 7 and 5

	Write a Boolean expression that checks for given integer if it can be divided (without remainder)
	by 7 and 5 at the same time.
*/

using System;

class DivideByNumber
{
	public static void Main ()
	{
		int number = 35;
		bool divideBySevenAndFive = (number % 7 == 0) && (number % 5 == 0);
		Console.WriteLine (divideBySevenAndFive);
	}
}