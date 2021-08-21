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
    protected void BindGrid(String s0)
    {
        Connection();
        s = "select * from Student where roll_no=@roll_no";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", s0);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
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
        s = "select * from Student where roll_no=@roll_no";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", TextBox1.Text);
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
        s = "select * from student where batch=@sem and dept_code=@dept_code";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sem", TextBox2.Text);
        cmd.Parameters.AddWithValue("@dept_code", DropDownList1.SelectedValue);
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
            Label2.Text = "Sorry! No search results.";
        }
        
        con.Close();

    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        Connection();
        s = "delete from student where roll_no=@rollno";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("rollno", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

        GridView1.EditIndex = 0;
        BindGrid(e.CommandArgument.ToString());



    }
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGrid(e.CommandArgument.ToString());
    }
    protected void LinkButton3_Command(object sender, CommandEventArgs e)
    {

        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        String s0 = (row.Cells[1].Controls[0] as TextBox).Text;
        String s1 = (row.Cells[2].Controls[0] as TextBox).Text;
        String s2 = (row.Cells[3].Controls[0] as TextBox).Text;
        String s3 = (row.Cells[4].Controls[0] as TextBox).Text;
        String s4 = (row.Cells[5].Controls[0] as TextBox).Text;
        String s5 = (row.Cells[6].Controls[0] as TextBox).Text;
        String s6 = (row.Cells[7].Controls[0] as TextBox).Text;
        String s7 = (row.Cells[8].Controls[0] as TextBox).Text;
        String s8 = (row.Cells[9].Controls[0] as TextBox).Text;
        String s9 = (row.Cells[10].Controls[0] as TextBox).Text;
        String s10 = (row.Cells[11].Controls[0] as TextBox).Text;
        String s11 = (row.Cells[12].Controls[0] as TextBox).Text;
        String s12 = (row.Cells[13].Controls[0] as TextBox).Text;
        String s13 = (row.Cells[14].Controls[0] as TextBox).Text;
        String s14 = (row.Cells[15].Controls[0] as TextBox).Text;
    
 

        Connection();
        s = "update student set roll_no=@s0,name=@s1,fath_na=@s2,per_address=@s4,clg_address=@s3,dobirth=@s5,doadmission=@s6,sem=@s7,ph_no=@s8,email=@s9,dept_code=@s10,advsr_fac_id=@s11,category=@s12,gender=@s13,batch=@s14 where roll_no=@s0";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@s0" ,s0);
        cmd.Parameters.AddWithValue("@s1", s1);

        cmd.Parameters.AddWithValue("@s2", s2);

        cmd.Parameters.AddWithValue("@s3", s3);
        cmd.Parameters.AddWithValue("@s4", s4);
        cmd.Parameters.AddWithValue("@s5", s5);
        cmd.Parameters.AddWithValue("@s6", s6);
        cmd.Parameters.AddWithValue("@s7", s7);

        cmd.Parameters.AddWithValue("@s8", s8);

        cmd.Parameters.AddWithValue("@s9", s9);

        cmd.Parameters.AddWithValue("@s10", s10);

        cmd.Parameters.AddWithValue("@s11", s11);

        cmd.Parameters.AddWithValue("@s12", s12);
        cmd.Parameters.AddWithValue("@s13", s13);
        cmd.Parameters.AddWithValue("@s14", s14);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid(s0);

        con.Close();

    }
}