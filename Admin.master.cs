using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToBoolean(Session["IsLogIn"]) == false)
        {
            Response.Redirect("Login.aspx");
        }


    }
    protected void logoutbtn_Click(object sender, EventArgs e)
    {
        Session["IsLogIn"] = false;
        Session.Abandon();
        FormsAuthentication.SignOut();
        FormsAuthentication.RedirectToLoginPage("Login.aspx");
        //Response.Redirect("Login.aspx");
    }
}
