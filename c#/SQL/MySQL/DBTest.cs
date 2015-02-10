using System;
using MySql.Data.MySqlClient;

class DBTest
{
	static void Main(string[] args)
	{
		string ConnectionData = "server=localhost;userid=user;password=password;database=database";

		MySqlConnection connection = null;

		try
		{
			connection = new MySqlConnection(ConnectionData);
			connection.Open();
			Console.WriteLine("MySql Version: " + connection.ServerVersion);
		} 
		catch (MySqlException ex)
		{
			Console.WriteLine("Error: " + ex.ToString());
		}
		finally
		{
			if (connection != null)
			{
				connection.Close();
			}
		}
	}
}
