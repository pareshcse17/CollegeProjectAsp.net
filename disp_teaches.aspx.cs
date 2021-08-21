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
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void BindGrid()
    {
        Connection();
        s = "select * from teaches where fac_id=@fac_id";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@fac_id", TextBox1.Text);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

        protected void Button1_Click(object sender, EventArgs e)
    {
        Connection();
        s = "select * from teaches where fac_id=@fac_id";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@fac_id", TextBox1.Text);
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
            s = "select * from teaches where c_code=@fac_id";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@fac_id", TextBox2.Text);
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
    
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGrid();
    }
    
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGrid();
    }
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        Connection();
        s = "delete from teaches where t_pk=@tpk";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@tpk", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        GridViewRow row = (sender as LinkButton).NamingContainer as GridViewRow;
        String s0 = (row.Cells[0].Controls[0] as TextBox).Text;

        String s1 = (row.Cells[1].Controls[0] as TextBox).Text;
        Connection();
        s = "update teaches set fac_id=@facid , c_code=@ccode where t_pk=@tpk";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@facid", s0);
        cmd.Parameters.AddWithValue("@ccode", s1);
        cmd.Parameters.AddWithValue("@tpk", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid();
        con.Close();
    }
}
