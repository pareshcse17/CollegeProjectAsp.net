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

public partial class Department : System.Web.UI.Page
{
    SqlDataAdapter adp;
    SqlCommand cmd;
    DataSet ds;
    SqlConnection con;
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
        s = "select * from department";
        adp = new SqlDataAdapter(s, con);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(! Page.IsPostBack  )
        {BindGrid();
        
        }
        
    }


    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        conn();
        s = "delete from department where dept_code=@dept_code";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@dept_code", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
        BindGrid();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGrid();
        
    }
   
    protected void Update_Click(object sender, EventArgs e)
    {
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        String s1=(row.Cells[0].Controls[0] as TextBox).Text;
        String s2 = (row.Cells[1].Controls[0] as TextBox).Text;
        String s3 = (row.Cells[2].Controls[0] as TextBox).Text;
        String s4 = (row.Cells[3].Controls[0] as TextBox).Text;
        conn();
        s = "update department set dept_code=@dept_code,name=@name,hod_id=@hod_id,no_courses=@no_courses where dept_code=@dept_code";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@dept_code", s1);
        cmd.Parameters.AddWithValue("@name", s2);
        cmd.Parameters.AddWithValue("@hod_id", s3);
        cmd.Parameters.AddWithValue("@no_courses", s4);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid();
        con.Close();
    }
    protected void Cancel_Click(object sender, EventArgs e)
    {
        GridView1.EditIndex = -1;
        this.BindGrid();
    }
}