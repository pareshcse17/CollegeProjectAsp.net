using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Login : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    String s;
    SqlDataReader dr;
    protected void conn()
    {
        s = WebConfigurationManager.ConnectionStrings["hello"].ToString();
        con = new SqlConnection(s);
        con.Open();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        if(CheckBox1.Checked)
        {
            conn();
            s = "select * from admin where id=@fac_id and pass=@pass";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@fac_id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["IsLogIn"] = true;

                Response.Redirect("ShowAll.aspx");
            }
            else
            {

                Label2.Text = "Password Incorrect or Not Registered yet.";
            }
            con.Close();
            TextBox1.Text = "";
        }
        else
        {
            conn();
            s = "select * from Faculty where email=@email and pass=@pass";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@email", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["IsLogIn"] = true;
                Session["id"] = TextBox1.Text;
                Session["Dept"] = dr["Dept_code"];
                Session["FacultyId"] = dr["fac_id"];
                Session["Name"] = dr["Name"];
                Response.Redirect("http://localhost:54742/fac_home.aspx");
            }
            else
            {

                Label2.Text = "Password Incorrect or Not Registered yet.";
            }
            con.Close();
            TextBox1.Text = "";
        }
    }
}