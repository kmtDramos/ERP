using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class Main
{

	public static void Init(Action<Connection> action)
	{
		Connection connection = new Connection();
		action(connection);
		connection.Close();
	}

}