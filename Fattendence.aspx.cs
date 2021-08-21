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


public partial class faculty_page_Fattendence : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    String s;
    SqlDataAdapter adp;
    DataSet ds;

    public void conn()
    {
        s = WebConfigurationManager.ConnectionStrings["hello"].ToString();
        con = new SqlConnection(s);
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            conn();
            s = "select courses.c_code,courses.title from courses inner join teaches on teaches.c_code=courses.c_code where fac_id=@facid";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@facid", Session["id"]);
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "title";
            DropDownList1.DataValueField = "c_code";
            DropDownList1.DataBind();
            con.Close();
        }

    }


    protected void Absent_Command(object sender, CommandEventArgs e)
    {
        conn();
        s = "insert into attendence values(@sub_id,@dates,'NO',@ccode,@session)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sub_id", GridView1.Rows[Convert.ToInt32(e.CommandArgument.ToString())].Cells[0].Text);
        cmd.Parameters.AddWithValue("@dates", TextBox2.Text);
        cmd.Parameters.AddWithValue("@ccode", GridView1.Rows[Convert.ToInt32(e.CommandArgument.ToString())].Cells[2].Text);
        cmd.Parameters.AddWithValue("@session", GridView1.Rows[Convert.ToInt32(e.CommandArgument.ToString())].Cells[3].Text);

        cmd.ExecuteReader();
        con.Close();

    }
    protected void Present_Command(object sender, CommandEventArgs e)
    {

        conn();
        s = "insert into attendence values(@sub_id,@dates,'YES',@ccode,@session)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sub_id", GridView1.Rows[Convert.ToInt32(e.CommandArgument.ToString())].Cells[0].Text);
        cmd.Parameters.AddWithValue("@dates", TextBox2.Text);
        cmd.Parameters.AddWithValue("@ccode", GridView1.Rows[Convert.ToInt32(e.CommandArgument.ToString())].Cells[2].Text);
        cmd.Parameters.AddWithValue("@session", GridView1.Rows[Convert.ToInt32(e.CommandArgument.ToString())].Cells[3].Text);

        cmd.ExecuteReader();
        con.Close();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn();
        s = "select * from stu_sub where c_code=@ccode and session=@batch";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@ccode", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@batch", TextBox1.Text);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
}