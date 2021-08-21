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


public partial class fee_rec_disp : System.Web.UI.Page
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
    protected void BindGrid(String sk)
    {
        Connection();
        s = "select * from fee_coll where trans_no=@transno";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@transno",sk);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
       
            GridView1.DataSource = ds;
            GridView1.DataBind();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Connection();
        s = "select * from fee_coll where roll_no=@roll_no";
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
        s = "select * from fee_coll where sem=@sem and batch=@batch";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@batch", TextBox2.Text);
        cmd.Parameters.AddWithValue("@sem",TextBox3.Text);
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
        s = "delete from fee_coll where trans_no=@trans_no";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@trans_no", e.CommandArgument.ToString());
        cmd.ExecuteNonQuery();
        Response.Redirect("disp_fee_rec.aspx");
    }

    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        GridView1.EditIndex = 0;
        BindGrid(e.CommandArgument.ToString());
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
        Connection();
        s = "update fee_coll set roll_no=@s1,sem=@s3,do_payment=@s4,amnt_paid=@s5,batch=@s2 where trans_no=@s0";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@s0", s0);
        cmd.Parameters.AddWithValue("@s1", s1);
        cmd.Parameters.AddWithValue("@s2", s2);
        cmd.Parameters.AddWithValue("@s3", s3);
        cmd.Parameters.AddWithValue("@s4", s4);
        cmd.Parameters.AddWithValue("@s5", s5);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        BindGrid(s0);
        con.Close();


    }
    
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGrid(e.CommandArgument.ToString());
    }
}