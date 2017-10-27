using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class ModelManage
{

	private JArray Tables = new JArray();

	public void GetModels (Connection conn)
	{
		string Query = "SELECT DISTINCT [Table] FROM V_Tables";
		SqlDataReader Data = conn.Exec(Query);
		if (Data.HasRows)
		{
			while (Data.Read())
			{
				JObject Columns = new JObject();
				for (int i = 0; i < Data.FieldCount; i++)
				{
					Columns.Add(Data.GetName(i), Data.GetValue(i));
				}
				Tables.Add(Columns);
			}
		}
	}

	public void CreateModels (Connection conn)
	{
		for (int i = 0; i < Tables.Count(); i++)
		{
			JObject Datos = JConvert.ToJObject(Tables.Get(i));
			string Query = "SELECT * FROM V_Tables WHERE [Table] = '" + Datos.Get("Table") +"'";
			SqlDataReader Data = conn.Exec(Query);
			if (Data.HasRows)
			{
				while (Data.Read())
				{

				}
			}
		}
	}

}