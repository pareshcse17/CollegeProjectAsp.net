using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class AdminHome : System.Web.UI.Page
{
    public SqlConnection con;
    public SqlCommand cmd;
    public SqlDataAdapter adp;
    public DataSet ds;
    public SqlDataReader dr;
    public String str;
    public void Connection()
    {
        str = WebConfigurationManager.ConnectionStrings["hello"].ToString();
        con = new SqlConnection(str);
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            GetFacultyDetails();
            getPath();
        }
    }
    protected void GetFacultyDetails()
    {
        Connection();
        str = "select * from Faculty where fac_id=@id";
        cmd = new SqlCommand(str, con);
        cmd.Parameters.AddWithValue("@id", Session["FacultyId"]);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox1.Text = dr["fac_id"].ToString();
            TextBox2.Text = dr["name"].ToString();
            TextBox3.Text = dr["email"].ToString();
            TextBox4.Text = dr["ph_no"].ToString();
            TextBox5.Text = dr["Dobirth"].ToString();
            TextBox6.Text = dr["per_address"].ToString();
            TextBox7.Text = dr["dept_code"].ToString();
           
        }
        con.Close();
    }
    public String getPath()
    {
        String s="";
        Connection();
        str = "select photo from Faculty where fac_id=@id";
        cmd = new SqlCommand(str, con);
        cmd.Parameters.AddWithValue("@id", Session["FacultyId"]);
        dr = cmd.ExecuteReader();
        if(dr.Read())
        {
        s = dr["photo"].ToString();
        }
        
        return s;
        con.Close();
    }
    
}