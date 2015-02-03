/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C#
 * Calculate the power of two given numbers.
*/


using System;

public class PowerOf 
{
	public static void Main(string[] args) 
	{
		double result;
		if (args.Length == 2) 
		{
			result = Math.Pow(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
		} 
		else if (args.Length == 0)
		{
			Console.Write("Enter the constant: ");
			double a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the exponent: ");
			double b = Convert.ToInt32(Console.ReadLine());

			result = Math.Pow(a, b);
		}
		else
		{
			Console.WriteLine("Too many or too few arguments");
			result = 0;
			Environment.Exit(1);
		}

		Console.WriteLine("Result is: " + result);
	}
}
