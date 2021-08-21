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

public partial class Fee_collection : System.Web.UI.Page
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
        s = "insert into fee_coll values(@roll_no,@sem,@do_payment,@amnt_paid,@batch)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", TextBox1.Text);
        cmd.Parameters.AddWithValue("@do_payment", TextBox2.Text);
        cmd.Parameters.AddWithValue("@amnt_paid", TextBox3.Text);
        cmd.Parameters.AddWithValue("@sem", DropDownList3.SelectedValue);
        cmd.Parameters.AddWithValue("@batch", TextBox4.Text);
        cmd.ExecuteNonQuery();
        con.Close();

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        
        TextBox1.Focus();
        Response.Redirect("disp_fee_resp.aspx");
    }
}