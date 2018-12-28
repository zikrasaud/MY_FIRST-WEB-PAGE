using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
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
        try
        {
            Conn.Open();
            cmd = new SqlCommand("insert into sign values('" + txt_name.Text.ToString() + "','" + txt_fname.Text.ToString() + "','" + txt_add.Text.ToString() + "','" + txt_mobile.Text.ToString() + "','" + txt_email.Text.ToString() + "','"+Txt_pwd.Text.ToString()+"') ", Conn);
            int z = cmd.ExecuteNonQuery();
            if (z > 0)
            {
                Response.Write("<Script>alert('sign up successfull..!!')</script>");
                txt_name.Text = "";
                txt_fname.Text = "";
                txt_add.Text = "";
                txt_mobile.Text = "";
                txt_email.Text = "";
                Txt_pwd.Text = "";
            }
            else
            {
                Response.Write("<Script>alert('sign up failed')</script>");
            }
        }
        catch (Exception ex)
        {
            //Response.Write(ex.ToString());
        }
        finally
        {
            Conn.Close();
        }

    }
}