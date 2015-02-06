/*
 * Frank Petrilli | frank@petril.li | frank.petril.li
 * Language: C#
 * Mail server tester
 */

using System;
using System.Text;
using System.ComponentModel;
using System.Net.Mail;

class MailServerTest
{
	static bool mailSent;

	static void Main(string[] args)
	{
		Console.Write("Server (hostname[:port]): ");
		string server = Console.ReadLine();
		SmtpClient client;
		if (server.Contains(":"))
		{
			char[] delimiters = {':'};
			string[] mailserver = server.Split(delimiters);
			client = new SmtpClient(mailserver[0], Convert.ToInt32(mailserver[1]));
		}
		else
		{
			client = new SmtpClient(server);
		}

		Console.Write("To Address (name@domain.com): ");
		string to = Console.ReadLine();

		Console.Write("From Address (name@domain.com): ");
		string from = Console.ReadLine();

		MailMessage message = new MailMessage(from, to);

		Console.Write("Subject: ");
		string subject = Console.ReadLine();
		message.Subject = subject;

		Console.WriteLine("Body (Use a . on its own line to quit):");
		StringBuilder result = new StringBuilder();
		bool isDone = false;
		do
		{
			string input;
			input = Console.ReadLine();
			if (input.Equals("."))
			{
				isDone = true;
			}
			else
			{
				result.AppendLine(input);
			}
		} while (!isDone);
		message.Body = result.ToString();
		client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
		string messageid = DateTime.Now.ToString();
		client.SendAsync(message, messageid);
		Console.WriteLine("Sending message...");
		Console.WriteLine("press c to cancel mail. Press any other key to exit.");
		string answer = Console.ReadLine();
		if (answer.StartsWith("c") && mailSent == false)
		{
			client.SendAsyncCancel();
		}
		message.Dispose();
	}

	private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
	{
		String token = (string) e.UserState;

		if (e.Cancelled)
		{
			Console.WriteLine("[{0}] Send canceled.", token);
		}
		if (e.Error != null)
		{
			Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
		} else
		{
			Console.WriteLine("Message with token ID " + token + " sent.");
		}
		mailSent = true;
	}
}
