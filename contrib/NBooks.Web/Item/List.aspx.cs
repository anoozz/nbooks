using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using NBooks.Core.Dao;
using NBooks.Data.NHibernate;

namespace NBooks.Web.Item
{
	public partial class List : System.Web.UI.Page
	{
		IItemDao dao = new NHibernateItemDao();

		protected void Page_Load(object sender, EventArgs e)
		{
			GridView1.DataSource = dao.FindActive();
			GridView1.DataBind();
		}
	}
}
