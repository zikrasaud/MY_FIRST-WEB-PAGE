using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection Conn;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        Conn = new SqlConnection();
        Conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["zikuConnectionString"].ToString();

    }
}