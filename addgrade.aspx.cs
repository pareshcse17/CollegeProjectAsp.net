using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class _Default : System.Web.UI.Page
{

    SqlConnection con;
    SqlCommand cmd;
    String s;
    public void Connection()
    {
        s = WebConfigurationManager.ConnectionStrings["hello"].ToString();
        con = new SqlConnection(s);
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Connection();
        s = "insert into grade values(@roll_no,@sem,@subids,@cgpa,@sgpa,@tot_credits)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", TextBox1.Text);
        cmd.Parameters.AddWithValue("@subids", TextBox2.Text);
        cmd.Parameters.AddWithValue("@cgpa", TextBox3.Text);
        cmd.Parameters.AddWithValue("@sgpa", TextBox4.Text);
        cmd.Parameters.AddWithValue("@tot_credits", TextBox5.Text);
        cmd.Parameters.AddWithValue("@sem", DropDownList3.SelectedValue);
        cmd.ExecuteReader();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox1.Focus();
    }
}