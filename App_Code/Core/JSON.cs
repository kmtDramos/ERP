using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class JSON
{
	
	// Convertir objetos a json
	public static string Stringify(object Obj)
	{
		return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(Obj);
	}

}