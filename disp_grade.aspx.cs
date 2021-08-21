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
public partial class disp_grade : System.Web.UI.Page
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
        s = "select * from GRADE where roll_no=@roll_no and sem=@sem";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", TextBox1.Text);
        cmd.Parameters.AddWithValue("@sem", TextBox2.Text);
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
        s = "select * from GRADE where roll_no=@roll_no and sem=@sem";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", TextBox1.Text);
        cmd.Parameters.AddWithValue("@sem", TextBox2.Text);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Label1.Text = "";
            
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label1.Text = "Sorry! No search results.";
        }

        con.Close();

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGrid();
    }
   
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        conn();
        s = "delete from grade where pk_id=@pkid";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@pkid", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGrid();
    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        String s0 = (row.Cells[0].Controls[0] as TextBox).Text;
        String s1 = (row.Cells[1].Controls[0] as TextBox).Text;
        String s2 = (row.Cells[2].Controls[0] as TextBox).Text;
        String s3 = (row.Cells[3].Controls[0] as TextBox).Text;
        String s4 = (row.Cells[4].Controls[0] as TextBox).Text;
        String s5 = (row.Cells[5].Controls[0] as TextBox).Text;
        conn();
        s = "update grade set roll_no=@roll_no,sem=@sem,sub_ids=@sub_ids,cgpa=@cgpa,sgpa=@sgpa,tot_credits=@tot_credits where pk_id=@pkid";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", s0);
        cmd.Parameters.AddWithValue("@sem", s1);
        cmd.Parameters.AddWithValue("@sub_ids", s2);
        cmd.Parameters.AddWithValue("@tot_credits", s3);
        cmd.Parameters.AddWithValue("@cgpa", s4);
        cmd.Parameters.AddWithValue("@sgpa", s5);
        cmd.Parameters.AddWithValue("@pkid", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid();
        con.Close();
    }
    protected void LinkButton3_Command(object sender, CommandEventArgs e)
    {

    }
}