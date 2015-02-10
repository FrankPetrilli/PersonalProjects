using System;
class DBManagerClient
{
	static void Main(string[] args)
	{
		DBManager db = new DBManager("userdb.sqlite");
		Console.WriteLine("Give a username to add them to the DB:");
		Console.WriteLine("(Blank line to quit)");
		bool isDone = false;
		int counter = 0;
		do
		{
			string input = Console.ReadLine();
			if (input.Equals(""))
			{
				isDone = true;
			}
			else
			{
				db.AddUser(input);
				counter++;
			}
		} while (!isDone);
		Console.WriteLine("Added " + counter + " users to DB");
	}
}

