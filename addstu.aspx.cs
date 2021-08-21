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
        if(!IsPostBack)
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
        string fileName=FileUpload1.FileName;
        FileUpload1.PostedFile.SaveAs(Server.MapPath("/StuImage/" + fileName));
        Connection();
        s = "insert into student values(@roll_no,@name,@fath_na,@per_address,@clg_address,@dob,@doadmission,@sem,@ph_no,@email,@dept_code,@advsr_fac_id,@category,@gender,@batch,@photo)";
        cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@roll_no", TextBox1.Text);
        cmd.Parameters.AddWithValue("@name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@dob", TextBox3.Text);
        cmd.Parameters.AddWithValue("@fath_na", TextBox4.Text);
        cmd.Parameters.AddWithValue("@clg_address", TextBox5.Text);
        if (TextBox6.ReadOnly == true)
        {
            cmd.Parameters.AddWithValue("@per_address", TextBox5.Text);
        }
        else
        {
            cmd.Parameters.AddWithValue("@per_address", TextBox6.Text);
        }
        cmd.Parameters.AddWithValue("@doadmission", TextBox7.Text);
        cmd.Parameters.AddWithValue("@ph_no", TextBox8.Text);
        cmd.Parameters.AddWithValue("@email", "");
        cmd.Parameters.AddWithValue("@advsr_fac_id", TextBox10.Text);
        cmd.Parameters.AddWithValue("@sem", TextBox11.Text);
        cmd.Parameters.AddWithValue("@batch", TextBox12.Text);
        cmd.Parameters.AddWithValue("@category", DropDownList1.SelectedValue);
        cmd.Parameters.AddWithValue("@dept_code", DropDownList2.SelectedValue);
        cmd.Parameters.AddWithValue("@gender", CheckBoxList1.SelectedValue);
        cmd.Parameters.AddWithValue("@photo", "/StuImage/"+ fileName);


        cmd.ExecuteReader();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        //TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox1.Focus();
     
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (TextBox6.ReadOnly == false)
        {
            TextBox6.ReadOnly = true;
        }
        else
            TextBox6.ReadOnly = false;



    }
}