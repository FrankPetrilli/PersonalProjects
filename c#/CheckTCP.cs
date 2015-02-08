using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

class CheckTCP
{
	static void Main(string[] args)
	{
		string ip;
		int portNum;

		if (args.Length == 2)
		{
			ip = args[0];
			portNum = Convert.ToInt32(args[1]);
		}
		else
		{
			Console.Write("Host: ");
			ip = Console.ReadLine();
			Console.Write("Port: ");
			portNum = Convert.ToInt32(Console.ReadLine());
		}

		StringBuilder builder = new StringBuilder();

		builder.Append(ip);
		builder.Append(":");
		builder.Append(portNum);
		builder.Append(" is ");
		builder.Append(InterpretToStatus(TryConnect(ip, portNum)));
		Console.WriteLine(builder.ToString());
	}

	static bool TryConnect(string address, int portNum)
	{
		using (TcpClient client = new TcpClient()) {
			try
			{
				client.Connect(address, portNum);
				client.GetStream().Close();
				client.Close();
				return true;
			}
			catch
			{
				client.Close();
				return false;
			}
		}
	}

	static string InterpretToStatus(bool status)
	{
		if (status)
		{
			return "open.";
		}
		else
		{
			return "closed.";
		}
	}

}
