using System;
using System.Collections.Generic;

class QueueDump
{
	static void Main(string[] args)
	{
		var q = new Queue<int>();
		int input;
		Console.Write("Enter integers followed by return (0 to end): ");
		do 
		{
			input = Convert.ToInt32(Console.ReadLine());
			if (input != 0)
			{
				q.Enqueue(input);
			}
		} while (input != 0);

		Console.WriteLine();

		while (q.Count != 0)
		{
			Console.WriteLine(q.Dequeue().ToString());
		}
	}
}
