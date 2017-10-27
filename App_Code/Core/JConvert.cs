using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class JConvert
{

	public static JObject ToJObject(object obj) 
	{
		JObject Obj = new JObject();

		try {
			Dictionary<string, object> dic = (Dictionary<string, object>)obj;
			foreach (string key in dic.Keys)
			{
				Obj.Add(key, dic[key]);
			}
		}
		catch (Exception ex)
		{
			throw new System.ArgumentException(ex.ToString());
		}

		return Obj;
	}

}