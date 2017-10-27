using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class JArray : JConvert
{
	
	private List<object> array;

	public JArray()
	{
		array = new List<object>();
	}

	public void Add(JObject obj)
	{
		array.Add(obj.ToDictionary());
	}

	public void Add(JArray arr)
	{
		array.Add(arr.ToList());
	}

	public void Add(object Value)
	{
		array.Add(Value);
	}

	public void Remove(int Index)
	{
		array.Remove(array[Index]);
	}

	public int Count()
	{
		return array.Count;
	}

	public object Get(int Index)
	{
		return array[Index];
	}

	public List<object> ToList()
	{
		return array;
	}

	override public string ToString()
	{
		string json = JSON.Stringify(array);
		json = json.Replace(@"\", "");
		return json;
	}

}