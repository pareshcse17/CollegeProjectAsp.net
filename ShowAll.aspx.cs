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
public partial class hello : System.Web.UI.Page
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
        GridView1.Visible = false;
        GridView2.Visible = false;
        GridView3.Visible = false;
        GridView4.Visible = false;
        GridView5.Visible = false;
        GridView6.Visible = false;
        GridView7.Visible = false;
        GridView8.Visible = false;
        GridView9.Visible = false;
        GridView10.Visible = false;

    }
    protected void BindGrid1()
    {
        Connection();
        s = "select * from Student ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
    }
    protected void BindGrid2()
    {
        Connection();
        s = "select * from Courses ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView2.DataSource = ds;
        GridView2.DataBind();
        con.Close();
    }
    protected void BindGrid3()
    {
        Connection();
        s = "select * from department ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView3.DataSource = ds;
        GridView3.DataBind();
        con.Close();
    }
    protected void BindGrid4()
    {
        Connection();
        s = "select * from stu_sub ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView4.DataSource = ds;
        GridView4.DataBind();
        con.Close();
    }
    protected void BindGrid5()
    {
        Connection();
        s = "select * from teaches ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView5.DataSource = ds;
        GridView5.DataBind();
        con.Close();
    }
    protected void BindGrid6()
    {
        Connection();
        s = "select * from assessment ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView6.DataSource = ds;
        GridView6.DataBind();
        con.Close();
    }
    protected void BindGrid7()
    {
        Connection();
        s = "select * from grade ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView7.DataSource = ds;
        GridView7.DataBind();
        con.Close();
    }
    protected void BindGrid8()
    {
        Connection();
        s = "select * from fee_coll ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView8.DataSource = ds;
        GridView8.DataBind();
        con.Close();
    }
    protected void BindGrid9()
    {
        Connection();
        s = "select * from fee_total ";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView9.DataSource = ds;
        GridView9.DataBind();
        con.Close();
    }
    protected void BindGrid10()
    {
        Connection();
        s = "select * from faculty";
        cmd = new SqlCommand(s, con);
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView10.DataSource = ds;
        GridView10.DataBind();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if(DropDownList1.SelectedValue=="1")
        {
            BindGrid1();
            GridView1.Visible = true;
        }
        else if(DropDownList1.SelectedValue=="2")
        {
            BindGrid2();
            GridView2.Visible = true;

        }
        else if (DropDownList1.SelectedValue == "3")
        {
            BindGrid3();
            GridView3.Visible = true;

        }
        else if (DropDownList1.SelectedValue == "4")
        {
            BindGrid4();
            GridView4.Visible = true;

        }
        else if (DropDownList1.SelectedValue == "5")
        {
            BindGrid5();
            GridView5.Visible = true;

        }
        else if (DropDownList1.SelectedValue == "6")
        {
            BindGrid6();
            GridView6.Visible = true;

        }
        else if (DropDownList1.SelectedValue == "7")
        {
            BindGrid7();
            GridView7.Visible = true;

        }
        else if (DropDownList1.SelectedValue == "8")
        {
            BindGrid8();
            GridView8.Visible = true;

        }
        else if (DropDownList1.SelectedValue == "9")
        {
            BindGrid9();
            GridView9.Visible = true;

        }
        else if (DropDownList1.SelectedValue == "10")
        {
            BindGrid10();
            GridView10.Visible = true;

        }
    }
}