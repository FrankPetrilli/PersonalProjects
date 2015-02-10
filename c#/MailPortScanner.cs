using System;
using System.Net.Sockets;
using System.Collections.Generic;

public class MailPortScanner
{
	public static Dictionary<int, bool> MailScan (string IpAddress)
	{
		//this.IpAddress = IpAddress;
		var result = new Dictionary<int, bool> ();
		TcpClient client = new TcpClient();
		int[] ports = { 25, 80, 110, 143, 443, 465, 587, 993, 995 };
		foreach (int port in ports) {
			try {
				client.Connect (IpAddress, port);
				// We take it the connect went successfully...
				client.GetStream ().Close ();
				System.Diagnostics.Debug.WriteLine ("Port number " + port + " was open.");
				result.Add (port, true);
			} catch {
				result.Add (port, false);
				System.Diagnostics.Debug.WriteLine ("Port number " + port + " was closed.");
			}
		}
		return result;
	}
}
