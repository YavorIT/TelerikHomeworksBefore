
/*
					Problem 5. Third Digit is 7?

	Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/

using System;

class IsDigitEqualToCertainNumber
{
	public static void Main ()
	{
		Console.Write ("Enter the number: ");
		int number = int.Parse (Console.ReadLine ());

		bool isSeven = ((number / 100) % 10) == 7;

		Console.WriteLine (isSeven);
	}
}