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
public partial class faculty_page_Fdisp_teaches : System.Web.UI.Page
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
        if (ds.Tables[0].Rows.Count>0)
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
}