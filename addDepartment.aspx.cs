using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

public partial class addDepartment : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    String s;
    public void conn()
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
        s = " insert into Department values(@dept_code,@name,@hod_id,@no_courses)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@dept_code", TextBox1.Text);
        cmd.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@hod_id", TextBox3.Text);
        cmd.Parameters.AddWithValue("@no_courses", TextBox4.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox1.Focus();

    }
}