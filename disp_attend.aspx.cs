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

public partial class disp_attend : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    String s;
    SqlDataAdapter adp;
    DataSet ds;

    protected void BindGrid()
    {
        conn();
        s = s = "select * from attendence where c_code=@ccode and session=@session";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@ccode", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@session", TextBox1.Text);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();

    }


    protected void conn()
    {
s=WebConfigurationManager.ConnectionStrings["hello"].ToString();

        con = new SqlConnection(s);
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            conn();
            s = "select title,c_code from courses";
            adp = new SqlDataAdapter(s, con);
            ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "title";
            DropDownList1.DataValueField = "c_code";
            DropDownList1.DataBind();
            con.Close();
        }
        
    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        
        GridView1.EditIndex = 0;
        BindGrid();
    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        Int32 x = Convert.ToInt32(e.CommandArgument.ToString());
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        String s0 = (row.Cells[0].Controls[0] as TextBox).Text;
        String s1 = (row.Cells[1].Controls[0] as TextBox).Text;
        String s2 = (row.Cells[2].Controls[0] as TextBox).Text;
        String s3 = (row.Cells[3].Controls[0] as TextBox).Text;
        String s4 = (row.Cells[4].Controls[0] as TextBox).Text;
        conn();
        s = "update attendence set sub_id=@subid,dates=@date,present=@present,c_code=@ccode,session=@session where sub_id=@subid and dates=@date";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@subid", s0);
        cmd.Parameters.AddWithValue("@date", s1);
        cmd.Parameters.AddWithValue("@present", s2);
        cmd.Parameters.AddWithValue("@ccode", s3);
        cmd.Parameters.AddWithValue("@session", s4);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid();
        con.Close();


    }
    protected void LinkButton3_Command(object sender, CommandEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGrid();
    }
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        
            conn();
            s = "delete from attendence where PK_ID=@PK";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@PK",e.CommandArgument.ToString());
           
            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn();
        s = "select * from attendence where c_code=@ccode and session=@session";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@ccode", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@session", TextBox1.Text);
        adp = new SqlDataAdapter(cmd);
        ds=new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();

    }
}