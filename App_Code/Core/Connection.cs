using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

public class Connection
{

	public bool Connected = false;
	public string Message = "";

	private SqlConnection connection;
	private string connectionString;
	private SqlCommand command;
	private SqlDataReader data;

	public Connection()
	{
		connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
		connection = new SqlConnection(connectionString);
		try
		{
			connection.Open();
			Connected = true;
		}
		catch (Exception ex)
		{
			Connected = false;
			Message = ex.Message;
		}
	}

	public SqlDataReader Exec(string Query)
	{
		command = new SqlCommand(Query, connection);
		data = command.ExecuteReader();
		return data;
	}

	public void Close()
	{
		connection.Close();
	}

}