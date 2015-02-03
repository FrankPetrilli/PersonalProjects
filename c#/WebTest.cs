using System;
using System.Net;

class WebTest 
{
	static void Main(string[] args) 
	{
		if (args.Length == 1)
		{
			WebClient client = new WebClient();
			Uri uri = new Uri(args[0]);
			Console.WriteLine(client.DownloadString(uri));
		}
		else
		{
			Console.WriteLine("Takes one parameter: A URL to parse.");
			Environment.Exit(-1);
		}
	}
}
