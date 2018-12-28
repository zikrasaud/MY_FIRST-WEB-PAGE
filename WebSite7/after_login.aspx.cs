using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class after_login : System.Web.UI.Page
{
    SqlConnection Conn;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
        Conn = new SqlConnection();
        Conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["zikuConnectionString"].ToString();

        try
        {
            Conn.Open();
            da = new SqlDataAdapter("select * from sign where name='" + Session["Login"].ToString() + "'", Conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lbl_name.Text = dt.Rows[0]["name"].ToString();
                lbl_fname.Text = dt.Rows[0]["f_name"].ToString();
                lbl_add.Text = dt.Rows[0]["address"].ToString();
                lbl_mobile.Text = dt.Rows[0]["mobile"].ToString();
                lbl_email.Text = dt.Rows[0]["email"].ToString();
            }
        }

        catch (Exception ex)
        {
        }

        finally
        {
            Conn.Close();
        }


    }
}