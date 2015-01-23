/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C#
 * Creates a Stack, feeds a line of text into it char by char, then spits it back out on the console.
 */

using System;
using System.Collections;

public class StackReverseString
{
	public static void Main(string[] args)
	{
		Stack s = new Stack();
		string input;
		if (args.GetLength(0) < 1) {
		       	Console.Write("Enter a string: ");
			input = Console.ReadLine();
		} else {
			input = args[0];
		}
		for (int i = 0; i < input.Length; i++)
		{
			s.Push(input[i]);
		}

		while (s.Count != 0)
		{
			Console.Write(s.Pop());
		}

		Console.WriteLine();

		if (args.GetLength(0) < 1) {
			Console.ReadLine();
		}
	}
}

