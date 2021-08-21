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
public partial class fee_total : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
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
        s = "insert into fee_total values(@sem,@gen_fee,@sc_fee,@st_fee)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sem", TextBox1.Text);
        cmd.Parameters.AddWithValue("@gen_fee", TextBox2.Text);
        cmd.Parameters.AddWithValue("@sc_fee", TextBox3.Text);
        cmd.Parameters.AddWithValue("@st_fee", TextBox4.Text);
        cmd.ExecuteReader();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox1.Focus();
    }
}