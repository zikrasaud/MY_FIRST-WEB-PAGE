using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
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
    protected void btn_login_Click(object sender, EventArgs e)
    {
        {
            Response.Redirect("Login.aspx");
        }

    }
    protected void btn_sign_Click(object sender, EventArgs e)
    {
        {
            Response.Redirect("Signup.aspx");
        }


    }
}