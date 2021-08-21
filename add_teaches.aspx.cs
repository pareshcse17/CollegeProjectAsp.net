using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter adp;
    DataSet ds;
    SqlDataReader dr;
    String s, st;
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
            s = "select title,c_code from courses";
            adp = new SqlDataAdapter(s, con);
            ds = new DataSet();
            adp.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "title";
            DropDownList1.DataValueField = "c_code";
            DropDownList1.DataBind();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Connection();
        s = "insert into teaches values(@fac_id,@c_code)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@fac_id", TextBox1.Text);
        cmd.Parameters.AddWithValue("c_code", DropDownList1.SelectedValue);
        cmd.ExecuteNonQuery();
        TextBox1.Text = "";
        TextBox1.Focus();

    }
}