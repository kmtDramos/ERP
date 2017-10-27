using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

public class ViewManage
{

	private string view;

	public void LoadView (string url)
	{
		WebClient client = new WebClient();
		view = client.DownloadString(url);
	}

	public string GetView()
	{
		return view;
	}

}