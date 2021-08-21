using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;
public partial class forgot_pass : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    String s;
    SqlDataReader dr;
    protected void conn()
    {
        s = WebConfigurationManager.ConnectionStrings["hello"].ToString();
        con = new SqlConnection(s);
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn();
        s = "UPDATE FACULTY SET PASS=@PASS where ph_no=@ph_no and dojoin=@dojoin and fac_id=@fac_id";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@ph_no", TextBox2.Text);
        cmd.Parameters.AddWithValue("@dojoin", TextBox3.Text);

        cmd.Parameters.AddWithValue("@fac_id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@pass", TextBox4.Text);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Label2.Text = "You are successfully registered";
        }
        else
        {
            Label2.Text = "Details do not match";
        }
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox1.Focus();
    }
}