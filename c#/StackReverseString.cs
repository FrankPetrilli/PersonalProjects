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
		Console.Write("Enter a string: ");
		string input = Console.ReadLine();
		for (int i = 0; i < input.Length; i++)
		{
			s.Push(input[i]);
		}

		while (s.Count != 0)
		{
			Console.Write(s.Pop());
		}
		Console.WriteLine();
	}
}

