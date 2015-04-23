/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C#
 * http://www.thousandtyone.com/blog/EasierThanFizzBuzzWhyCantProgrammersPrint100To1.aspx
 * Solved in less than 30 seconds.
 */

using System;

class EasierThanFizzBuzz
{
	static void Main(string[] args)
	{
		for (int i = 0; i < 100; i++)
		{
			Console.WriteLine(100 - i);
		}
	}
}
