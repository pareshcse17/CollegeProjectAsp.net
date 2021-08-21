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

public partial class faculty_page_Fdisp_courses : System.Web.UI.Page
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
        if (ds.Tables[0].Rows.Count > 0)
        {
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
    }
