using System;
using System.Collections;

class SortingAlgorithms
{
	static void Main(string[] args) 
	{
		ArrayList list = new ArrayList();
		Random r = new Random();

		for (int i = 0; i < 10000000; i++) {
			int randomNumber = r.Next(0,10000);
			list.Add(randomNumber);
		}

		list.Sort();

		for (int i = 0; i < list.Count; i++) {
			Console.Write(list[i] + ", ");
		}
	}
}
