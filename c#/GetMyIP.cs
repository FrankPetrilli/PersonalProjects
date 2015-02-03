using System;
using System.Net;

class GetMyIP 
{
	static void Main(string[] args)
	{
		Console.Write(new WebClient().DownloadString(new Uri("http://icanhazip.com")));
	}
}
