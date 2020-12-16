using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["Admin"] != null)
        {
            lb.Text = "欢迎回来,管理员 " + Session["Name"];
        }
        else if (Session["Name"] != null)
        {
            lb.Text = "Welcome back," + Session["Name"];
        }
        else
        {
            Response.Redirect("./Default.aspx");
        }
    }

}