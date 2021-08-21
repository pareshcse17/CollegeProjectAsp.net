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

public partial class faculty_page_Fdisp_assessment : System.Web.UI.Page
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
    protected void BindGrid()
    {
        Connection();
        s = "select assessment.sub_id,assessment.s1,assessment.s2,assessment.endS,assessment.other,assessment.attend,assessment.totalm,assessment.gradep from assessment inner join stu_sub on assessment.sub_id=stu_sub.sub_id where c_code=@c_code and session=@session";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@c_code", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@session", TextBox2.Text);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
   
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        Connection();
        s = "delete from assessment where sub_id=@sub_id";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sub_id", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
        Response.Redirect("disp_assessment.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Connection();
        s = "select assessment.sub_id,assessment.s1,assessment.s2,assessment.endS,assessment.other,assessment.attend,assessment.totalm,assessment.gradep from assessment inner join stu_sub on assessment.sub_id=stu_sub.sub_id where c_code=@c_code and session=@session";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@c_code", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@session", TextBox2.Text);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Label2.Text = "";
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label2.Text = "Sorry! No search results.";
        }

        con.Close();
    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        GridView1.EditIndex = 0;
        BindGrid();
    }
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        GridView1.EditIndex = -1;
        this.BindGrid();
    }
    protected void LinkButton3_Command(object sender, CommandEventArgs e)
    {
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        String s0 = (row.Cells[0].Controls[0] as TextBox).Text;
        String s1 = (row.Cells[1].Controls[0] as TextBox).Text;
        String s2 = (row.Cells[2].Controls[0] as TextBox).Text;
        String s3 = (row.Cells[3].Controls[0] as TextBox).Text;
        String s4 = (row.Cells[4].Controls[0] as TextBox).Text;
        String s5 = (row.Cells[5].Controls[0] as TextBox).Text;
        String s6 = (row.Cells[6].Controls[0] as TextBox).Text;
        String s7 = (row.Cells[7].Controls[0] as TextBox).Text;
        Connection();
        s = "update assessment set sub_id=@sub_id,s1=@s1,s2=@s2,ends=@ends,other=@other,attend=@attend,totalm=@totalm,gradep=@gradep where sub_id=@sub_id";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sub_id", s0);
        cmd.Parameters.AddWithValue("@s1", s1);
        cmd.Parameters.AddWithValue("@s2", s2);
        cmd.Parameters.AddWithValue("@ends", s3);
        cmd.Parameters.AddWithValue("@other", s4);
        cmd.Parameters.AddWithValue("@attend", s5);
        cmd.Parameters.AddWithValue("@GradeP", s7);
        cmd.Parameters.AddWithValue("@Totalm", s6);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid();
        con.Close();
    }
}