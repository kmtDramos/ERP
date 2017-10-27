using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

	protected void Page_Load(object sender, EventArgs e)
	{
		Main.Init(delegate (Connection conn) {
			ModelManage Model = new ModelManage();
			Model.GetModels(conn);
			Model.CreateModels(conn);
		});
	}

}