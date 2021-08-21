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
    int x=0;
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
    protected void BindGrid(String s0)
    {
        
        
 Connection();
        s = "select * from Courses where c_code=@c_code";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@c_code", s0);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
        
       
        
        
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
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "dept_code";
            DropDownList1.DataBind();
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        Connection();
        s = "select * from Courses where c_code=@c_code";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@c_code", TextBox1.Text);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Label1.Text = "";
            Label2.Text = "";
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Connection();
        
        s = "select * from courses where dept_code=@dept_code";
        cmd = new SqlCommand(s, con);
        
        cmd.Parameters.AddWithValue("@dept_code", DropDownList1.SelectedValue);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count >0)
        {
            Label1.Text = "";
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
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        Connection();
        s = "delete from courses where c_code=@c_code";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@c_code", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
        con.Close();
        
    }
   
    
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        GridView1.EditIndex = -1;
        this.BindGrid(e.CommandArgument.ToString());
    }
  
    protected void LinkButton3_Command1(object sender, CommandEventArgs e)
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
        String s8 = (row.Cells[8].Controls[0] as TextBox).Text;
        Connection();
        s = "update courses set c_code=@c_code,dept_code=@dept_code,title=@title,C_credits=@C_credits,lec_w=@lec_w,prac_w=@prac_w,core=@core,sem=@sem,about=@about where c_code=@c_code";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@c_code", s0);
        cmd.Parameters.AddWithValue("@title", s2);
        cmd.Parameters.AddWithValue("@c_credits", s3);
        cmd.Parameters.AddWithValue("@lec_w", s4);
        cmd.Parameters.AddWithValue("@prac_w", s5);
        cmd.Parameters.AddWithValue("@sem", s7);
        cmd.Parameters.AddWithValue("@about", s8);
        cmd.Parameters.AddWithValue("@dept_code", s1);
        cmd.Parameters.AddWithValue("@core", s6);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid(s0);
        con.Close();
    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        GridView1.EditIndex = 0;
        BindGrid(e.CommandArgument.ToString());
    }
}

