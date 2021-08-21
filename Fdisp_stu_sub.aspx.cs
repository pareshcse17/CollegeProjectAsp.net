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
public partial class faculty_page_Fdisp_stu_aspx : System.Web.UI.Page
{

     SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter adp;
    DataSet ds;
    String s;
    public void conn()
    {
        s = WebConfigurationManager.ConnectionStrings["hello"].ToString();
        con = new SqlConnection(s);
        con.Open();
    }
    protected void BindGrid()
    {
        conn();
        s = "select * from stu_sub where roll_no=@roll_no and sem=@sem";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@sem", DropDownList3.SelectedValue);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn();
        s = "select * from stu_sub where roll_no=@roll_no and sem=@sem";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no",DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@sem", DropDownList3.SelectedValue);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

        con.Close();

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGrid();

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        String s0 = (row.Cells[0].Controls[0] as TextBox).Text;
        String s1 = (row.Cells[1].Controls[0] as TextBox).Text;
        String s2 = (row.Cells[2].Controls[0] as TextBox).Text;
        String s3 = (row.Cells[3].Controls[0] as TextBox).Text;
        String s4 = (row.Cells[4].Controls[0] as TextBox).Text;

        conn();
        s = "update stu_sub set sub_id=@subid,roll_no=@rollno,c_code=@ccode,sem=@sem,session=@s4 where sub_id=@subid";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@subid", s0);
        cmd.Parameters.AddWithValue("@rollno", s1);
        cmd.Parameters.AddWithValue("@ccode", s2);
        cmd.Parameters.AddWithValue("@sem", s3);
        cmd.Parameters.AddWithValue("@s4", s4);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid();
        con.Close();
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        GridView1.EditIndex = -1;
        this.BindGrid();
    }
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        conn();
        s = "delete from stu_sub where sub_id=@subid";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@subid", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        conn();
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