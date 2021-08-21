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

public partial class faculty_page_Faad_grade : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter adp;
    String s;
    DataSet ds;
    public void Connection()
    {
        s = WebConfigurationManager.ConnectionStrings["hello"].ToString();
        con = new SqlConnection(s);
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox6.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Connection();
        s = "insert into grade values(@roll_no,@sem,@subids,@cgpa,@sgpa,@tot_credits)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", DropDownList1.SelectedValue );
        cmd.Parameters.AddWithValue("@subids", TextBox2.Text);
        cmd.Parameters.AddWithValue("@cgpa", TextBox3.Text);
        cmd.Parameters.AddWithValue("@sgpa", TextBox4.Text);
        cmd.Parameters.AddWithValue("@tot_credits", TextBox5.Text);
        cmd.Parameters.AddWithValue("@sem", DropDownList3.SelectedValue);
        cmd.ExecuteReader();
        con.Close();
        TextBox6.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox6.Focus();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
     
           Connection();
            s = "select * from student where advsr_fac_id=@facid and batch=@batch";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@facid", Session["id"]);
            cmd.Parameters.AddWithValue("@batch", TextBox6.Text);
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "roll_no";
            DropDownList1.DataValueField = "roll_no";
            DropDownList1.DataBind();
           
        }
    
}