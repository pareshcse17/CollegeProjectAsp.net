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
    SqlDataAdapter adp;
    DataSet ds;
    SqlDataReader dr;
    String s;
    public void Connection()
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
        Connection();
        
        s = "insert into Assessment values(@sub_id,@s1,@s2,@ends,@other,@attend,@totalm,@Gradep)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sub_id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@s1", TextBox2.Text);
        cmd.Parameters.AddWithValue("@s2", TextBox7.Text);
        cmd.Parameters.AddWithValue("@ends", TextBox5.Text);
        cmd.Parameters.AddWithValue("@other", TextBox3.Text);
        cmd.Parameters.AddWithValue("@attend", TextBox4.Text);
        cmd.Parameters.AddWithValue("@GradeP", TextBox6.Text);
        cmd.Parameters.AddWithValue("@Totalm", TextBox8.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox1.Focus();
    }
}