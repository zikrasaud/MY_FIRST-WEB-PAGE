using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
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
            da = new SqlDataAdapter("select * from sign where name='" + Txt_name.Text.ToString() + "' and password='" + Txt_pwd.Text.ToString() + "'", Conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["Login"]=dt.Rows[0]["name"].ToString();
                Response.Write("<Script>alert('successfull')</script>");
                Response.Redirect("after_login.aspx");

            }
            else
            {
                Response.Write("<Script>alert('login failed')</script>");
            }

        }
        catch (Exception ex)
        {
           // Response.Write(ex.ToString());
        }
        finally
        {
            Conn.Close();
        }
    }

    }
