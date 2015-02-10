using System;
using System.Data;
using System.Data.SqlClient;
using Mono.Data.Sqlite;
using System.IO;

public class DBManager
{
	private SqliteConnection dbConnection;
	Mono.Data.Sqlite.SqliteCommand cmd;

	public DBManager(string DatabaseName)
	{
		if (!File.Exists(DatabaseName))
		{
			SqliteConnection.CreateFile(DatabaseName);
		}

		dbConnection = new SqliteConnection("Data Source=" + DatabaseName + ";Version=3;");
		dbConnection.Open();
		cmd = dbConnection.CreateCommand();
		string checkForTable = "SELECT name FROM sqlite_master WHERE type='table' AND name='users';";
		cmd.CommandText = checkForTable;
		if (cmd.ExecuteNonQuery() == 0)
		{
			string create = "CREATE TABLE users (id INT PRIMARY KEY, name CHAR(50));";
			cmd = dbConnection.CreateCommand();
			cmd.CommandText = create;
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch
			{
				System.Diagnostics.Debug.WriteLine("Table already exists...");
			}
		}
		cmd = null;

	}

	public void AddUser(string username)
	{
		string insertuser = "INSERT INTO users (name) VALUES (\"" + username + "\");";
		//Console.WriteLine(insertuser);
		cmd = dbConnection.CreateCommand();
		cmd.CommandText = insertuser;
		cmd.ExecuteNonQuery();
	}
}

