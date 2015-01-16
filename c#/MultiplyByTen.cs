using System;

public class MultiplyByTen 
{
	public static int Main (string [] args) 
	{
		string input = Console.ReadLine();
		int inputAsInt = Convert.ToInt32(input);
		for (int i = 0; i <= 10; i++) 
		{
			Console.WriteLine(inputAsInt * 10);
		}
		return 0;
	}
}
