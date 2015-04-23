using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;

class Server
{
	private TcpListener tcp_listener;
	private Thread listener_thread;
	private string PATH = Directory.GetCurrentDirectory();

	static void Main(string[] args)
	{
		new Server();
	}

	public Server()
	{
		this.tcp_listener = new TcpListener(IPAddress.Any, 8080);
		this.listener_thread = new Thread(new ThreadStart(ListenForClients));
		this.listener_thread.Start();
	}

	private void ListenForClients()
	{
		this.tcp_listener.Start();

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
		ASCIIEncoding encoder = new ASCIIEncoding();

		byte[] message = new byte[4096];
		int bytes_read;
		int failed = 0;
		bool exit = false;

		Console.WriteLine("New client: " + tcp_client.Client.RemoteEndPoint.ToString());

		string prompt = "(FileGetter) > ";
		byte[] send_buffer = encoder.GetBytes(prompt);
		/*client_stream.Write(send_buffer, 0, send_buffer.Length);
		client_stream.Flush();*/
		

		while (!exit && failed < 30) 
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
				failed++;
				Thread.Sleep(1);
			}
			else
			{
				failed = 0;
				String user_input = encoder.GetString(message, 0, bytes_read);
				user_input = user_input.Trim();
				if (user_input.Equals("exit"))
				{
					exit = true;
				}
				else
				{
					Console.WriteLine(user_input);
					string result = "";
					try
					{
						result += "HTTP/1.1 200 OK\n\n";
						string[] user_input_broken = user_input.Split(new char[]{' '});
						string path = user_input_broken[1];
						Console.WriteLine(PATH + path);
						string my_path = Path.Combine(PATH, path.Replace("/",""));
						if (my_path.Equals("/"))
						{
							my_path = "./index.html";
						}
						Console.WriteLine("Getting: " + my_path);
						var lines = File.ReadLines(my_path);
						foreach (string line in lines)
						{
							result += line + "\n";
						}
					}
					catch
					{
						result = "HTTP/1.1 404 File not found\r\nFailed to get file.\r\n";
					}
					//result += "\r\n" + prompt;
					send_buffer = encoder.GetBytes(result);
					client_stream.Write(send_buffer, 0, send_buffer.Length);
					client_stream.Flush();
					tcp_client.Close();
				}
			}
		}
		//Console.WriteLine("Disconnect of client: " + tcp_client.Client.RemoteEndPoint.ToString());
		//tcp_client.Close();
	}
}

