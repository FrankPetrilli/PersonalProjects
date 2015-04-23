using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using System.Collections.Generic;

class Server
{
	private static readonly int PORT = 8080;
	private string PROMPT = "";
	private TcpListener tcp_listener;
	private Thread listener_thread;
	private HashSet<Socket> connected_users;
	private Dictionary<Socket, string> user_names;
	private ASCIIEncoding encoder;
	private String my_newline = "\r\n";
	//private string PROMPT = "(Message) > ";
	private string greeting = "Welcome to the server.";

	static void Main(string[] args)
	{
		new Server();
	}

	public Server()
	{
		this.tcp_listener = new TcpListener(IPAddress.Any, PORT);
		this.listener_thread = new Thread(new ThreadStart(ListenForClients));
		this.listener_thread.Start();
		this.connected_users = new HashSet<Socket>();
		this.user_names = new Dictionary<Socket, string>();
		this.encoder = new ASCIIEncoding();
		this.greeting = UpdateGreeting();
	}

	private string UpdateGreeting()
	{
		StringBuilder my_greeting = new StringBuilder();
		my_greeting.AppendLine("Welcome to this C# TCP chat server.\r");
		my_greeting.AppendLine("Commands are prefaced with a /\r");
		my_greeting.AppendLine("Register your name with /name <your name>\r");
		return my_greeting.ToString();
	}


	private void ListenForClients()
	{
		this.tcp_listener.Start();
		Console.WriteLine("[server] Server started on " + PORT);

		while (true)
		{
			TcpClient client = this.tcp_listener.AcceptTcpClient();

			Thread client_thread = new Thread(new ParameterizedThreadStart(HandleClientCommunication));
			client_thread.Start(client);
		}
	}

	private void HandleClientCommunication(object client)
	{
		TcpClient tcp_client = (TcpClient)client;
		NetworkStream client_stream = tcp_client.GetStream();

		byte[] message = new byte[4096];
		int bytes_read;
		int timeout = 0;
		bool exit = false;

		Console.WriteLine("[server] New client: " + tcp_client.Client.RemoteEndPoint.ToString());
		connected_users.Add(tcp_client.Client);

		byte[] send_buffer = encoder.GetBytes(greeting + my_newline + PROMPT);
		client_stream.Write(send_buffer, 0, send_buffer.Length);
		client_stream.Flush();
		

		while (!exit && timeout < 60) 
		{
			bytes_read = 0;

			try
			{
				bytes_read = client_stream.Read(message, 0, message.Length);
			}
			catch
			{
			}

			if (bytes_read == 0)
			{
				timeout++;
				Thread.Sleep(1);
			}
			else
			{
				timeout = 0;
				String user_input = encoder.GetString(message, 0, bytes_read);
				user_input = user_input.Trim();
				if (user_input.StartsWith("/"))
				{
					if (user_input.Equals("/exit"))
					{
						exit = true;
					}
					else if (user_input.StartsWith("/name"))
					{
						string name = "";
						string[] command = user_input.Split(new char[] {' '});
						for (int i = 1; i < command.Length; i++)
						{
							name += command[i] += " ";
						}
						user_names.Add(tcp_client.Client, name.Trim());
						ReplyNewLine(client_stream);
					}
					else if (user_input.StartsWith("/help"))
					{
						StringBuilder help = new StringBuilder();
						help.AppendLine("Recognized commands are:");
						help.AppendLine("\t/name <name>\tSets a user's name");
						help.AppendLine("\t/exit       \tExits the server");
						send_buffer = encoder.GetBytes(help.ToString());
						client_stream.Write(send_buffer, 0, send_buffer.Length);
						client_stream.Flush();
					} 
					else 
					{
						send_buffer = encoder.GetBytes("Command unknown");
						client_stream.Write(send_buffer, 0, send_buffer.Length);
						client_stream.Flush();
					}
				}
				else
				{
					// Send to all users.
					string name;
					try
					{
						name = user_names[tcp_client.Client];
					}
					catch
					{
						name = "Unregistered User";
					}
					Console.Write(my_newline + name + ": " + user_input + my_newline);
					send_buffer = encoder.GetBytes(my_newline + name + ": " + user_input + my_newline);
					foreach (Socket user in connected_users)
					{
						NetworkStream stream = new NetworkStream(user);
						stream.Write(send_buffer, 0, send_buffer.Length);
						stream.Flush();
					}

					ReplyNewLine(client_stream);
				}
			}
		}
		Console.WriteLine("[server] Disconnect of client: " + tcp_client.Client.RemoteEndPoint.ToString());
		connected_users.Remove(tcp_client.Client);
		tcp_client.Close();
	}

	private void ReplyNewLine(NetworkStream client_stream)
	{
		byte[] send_buffer = encoder.GetBytes(my_newline + PROMPT);
		client_stream.Write(send_buffer, 0, send_buffer.Length);
		client_stream.Flush();
	}
}
