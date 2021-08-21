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
public partial class disp_fee_tot : System.Web.UI.Page
{
    SqlDataAdapter adp;
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
        s = "select * from fee_total";
        adp = new SqlDataAdapter(s, con);
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
            BindGrid();
        }
    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        conn();
        s = "delete from fee_total where sem=@sem";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sem", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
        Response.Redirect("disp_fee_tot.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        String s0 = (row.Cells[0].Controls[0] as TextBox).Text;
        String s1 = (row.Cells[1].Controls[0] as TextBox).Text;
        String s2 = (row.Cells[2].Controls[0] as TextBox).Text;
        String s3 = (row.Cells[3].Controls[0] as TextBox).Text;
        conn();
        s = "update fee_total set sem=@sem,tution=@tution,messhostel=@messhostel,other=@other where sem=@sem";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@sem", s0);
        cmd.Parameters.AddWithValue("@tution", s1);
        cmd.Parameters.AddWithValue("@messhostel", s2);
        cmd.Parameters.AddWithValue("@other", s3);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid();
        con.Close();

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        GridView1.EditIndex = -1;
        this.BindGrid();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGrid();
    }
}