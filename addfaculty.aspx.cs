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

public partial class addfaculty : System.Web.UI.Page
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
            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "name";
            DropDownList2.DataValueField = "dept_code";
            DropDownList2.DataBind();
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fileName = FileUpload1.FileName;
        FileUpload1.PostedFile.SaveAs(Server.MapPath("/FacImage/" + fileName));
        Connection();
        s = "insert into Faculty values(@fac_id,@name,@per_address,@res_address,@ph_no,@email,@qualification,@expirience,@dobirth,@dojoin,@salary,'',@dept_code,@gender,@photo)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@fac_id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@dobirth", TextBox3.Text);
        if(TextBox4.ReadOnly == true)
        {
            cmd.Parameters.AddWithValue("@per_address", TextBox6.Text);
        }
        else
        {
            cmd.Parameters.AddWithValue("@per_address", TextBox4.Text);
        }
       
        cmd.Parameters.AddWithValue("@ph_no", TextBox5.Text);
        cmd.Parameters.AddWithValue("@res_address", TextBox6.Text);
        cmd.Parameters.AddWithValue("@email", TextBox7.Text);
        cmd.Parameters.AddWithValue("@qualification", TextBox8.Text);
        cmd.Parameters.AddWithValue("@dojoin", TextBox9.Text);
        cmd.Parameters.AddWithValue("@salary", TextBox10.Text);
        cmd.Parameters.AddWithValue("@expirience", TextBox11.Text);
       
        cmd.Parameters.AddWithValue("@dept_code", DropDownList2.SelectedValue);
        cmd.Parameters.AddWithValue("@gender", CheckBoxList1.SelectedValue);
        cmd.Parameters.AddWithValue("@photo", "/FacImage/"+ fileName);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox1.Focus();
        TextBox4.ReadOnly = false;
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (TextBox4.ReadOnly == false)
        {
            TextBox4.ReadOnly = true;
        }
        else
            TextBox4.ReadOnly = false;
            
        
         
    }
}