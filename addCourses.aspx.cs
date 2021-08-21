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
        if (!IsPostBack)
        {
            Connection();
            s = "select name,dept_code from Department";
            adp = new SqlDataAdapter(s, con);
            ds = new DataSet();
            adp.Fill(ds);
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "name";
            DropDownList2.DataValueField = "dept_code";
            DropDownList2.DataBind();
            con.Close();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Connection();
        if (CheckBox1.Checked)
            s = "insert into courses values(@c_code,@dept_code,@title,@c_credits,@lec_w,@prac_w,'YES',@sem,@about)";
        else
            s = "insert into courses values(@c_code,@dept_code,@title,@c_credits,@lec_w,@prac_w,'NO',@sem,@about)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@c_code", TextBox1.Text);
        cmd.Parameters.AddWithValue("@title", TextBox2.Text);
        cmd.Parameters.AddWithValue("@c_credits", TextBox3.Text);
        cmd.Parameters.AddWithValue("@lec_w", TextBox4.Text);
        cmd.Parameters.AddWithValue("@prac_w", TextBox5.Text);
        cmd.Parameters.AddWithValue("@sem", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@about", TextBox7.Text);
        cmd.Parameters.AddWithValue("@dept_code", DropDownList2.SelectedValue);
        cmd.ExecuteReader();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
      
        TextBox7.Text = "";
        TextBox1.Focus();
    }
}