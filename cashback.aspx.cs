using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBM3
{
    public partial class cashback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            payment.Click += new EventHandler(this.bcktopayments);
        }
        protected void bcktopayments(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MyDB"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            Response.Redirect("payments");

        }
    }
}