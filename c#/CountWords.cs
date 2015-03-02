using System;
using System.IO;
using System.Collections.Generic;

class CountWords
{
	private static readonly int THRESHOLD = 60;
	private static readonly bool IGNORECOMMON = true;
	private static HashSet<string> commonWordSet;
	private static readonly string[] COMMONWORDS = {"the", "had", "with", "at", "as", "that", "you", "said", "was", "in", "it", "of", "a", "and", "he", "her", "him", "his", "hers", "to", "and", "but", "is"};
	static void Main(string[] args)
	{
		commonWordSet = new HashSet<string>(COMMONWORDS);
		commonWordSet.AddAll(COMMONWORDS);
		string filename;
		if (args.Length != 1)
		{
			Console.Write("Enter a filename: ");
			filename = Console.ReadLine();
		}
		else
		{
			filename = args[0];
		}
		long initialTime = CalculateTime.CurrentTimeMillis();
		StreamReader inputstream = new StreamReader(filename);

		string input = inputstream.ReadToEnd();
		string[] words = input.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' , '\"', '\n', '\'', '-'}, StringSplitOptions.RemoveEmptyEntries);
		
		Dictionary<string,Word> wordlist = new Dictionary<string,Word>();

		foreach (string word in words)
		{
			if (word.Length == 1 && (!word.Equals("a") && !word.Equals("i"))) {
				continue;
			}
			if (IGNORECOMMON && commonWordSet.Contains(word)) {
				continue;
			}
			string myWord = word.Trim().ToLower();
			if (myWord.Length <= 0)
			{
				continue;
			}
			if(!wordlist.ContainsKey(myWord))
			{
				wordlist.Add(myWord, new Word(myWord));
			}
			else
			{
				wordlist[myWord].AddOne();
			}
		}

		SortedSet<Word> sorted = new SortedSet<Word>(wordlist.Values);

		foreach (Word myWord in sorted)
		{
			if (myWord.count > THRESHOLD)
			{
				Console.WriteLine(myWord.ToString());
			}
		}
		Console.WriteLine();
		Console.WriteLine("Compute time: " + (CalculateTime.CurrentTimeMillis() - initialTime).ToString() + "ms");
	}
}

class Word : IEquatable<Word>, IComparable<Word>
{
	public string word;
	public int count;

	public Word(string word)
	{
		this.word = word;
		count = 1;
	}

	public Word(string word, int count)
	{
		this.word = word;
		this.count = count;
	}

	public void AddOne()
	{
		count++;
	}

	public override string ToString()
	{
		return "Count: " + count + "\t" + word;
	}

	public bool Equals(Word other)
	{
		return (other.word.Equals(this.word));
	}

	public int CompareTo(Word other)
	{
		return this.count.CompareTo(other.count);
	}
}

class CalculateTime
{
	private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	public static long CurrentTimeMillis()
	{
		return (long) (DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
	}
}
