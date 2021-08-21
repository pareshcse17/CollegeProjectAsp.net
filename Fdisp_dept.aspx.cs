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
public partial class faculty_page_Fdisp_dept : System.Web.UI.Page
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
        if (!Page.IsPostBack)
        {
            BindGrid();

        }

    }
}