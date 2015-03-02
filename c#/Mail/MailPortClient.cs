using System;
using System.Collections.Generic;

class MailPortClient
{
	static void Main(string[] args)
	{
		string host;
		if (args.Length == 1)
		{
			host = args[0];
		}
		else
		{
			host = "imap.gmail.com";
		}
		var result = MailPortScanner.MailScan(host);
		foreach (KeyValuePair <int, bool> kvp in result)
		{
			Console.Write(kvp.Key.ToString());
			Console.Write(kvp.Value.ToString());
			Console.WriteLine();
		}
	}
}

