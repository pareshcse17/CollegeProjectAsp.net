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

public partial class faculty_page_Fadd_stu_sub : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter adp;
    DataSet ds;
    SqlDataReader dr;
    String s, st;
    public void Connection()
    {
        s = WebConfigurationManager.ConnectionStrings["hello"].ToString();
        con = new SqlConnection(s);
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();

        if (!IsPostBack)
        {
            Connection();
            s = "select courses.title,courses.c_code from courses inner join TEACHES on courses.c_code=TEACHES.c_code where fac_id=@fac_id";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@fac_id", Session["id"]);
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "title";
            DropDownList1.DataValueField = "c_code";
            DropDownList1.DataBind();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Connection();
        s = "insert into stu_sub values (@sub_id,@roll_no, @c_code,@sem,@session)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", TextBox2.Text);
        cmd.Parameters.AddWithValue("@sub_id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@sem", DropDownList3.SelectedValue);
        cmd.Parameters.AddWithValue("@c_code", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@session", TextBox3.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox1.Focus();


    }
}