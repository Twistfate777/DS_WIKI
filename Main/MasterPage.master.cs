using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    DB db = new DB();
    Table user;
    protected void Page_Load(object sender, EventArgs e)
    {
        user = Session["User"] as Table;
        HandleLogin();
    }

    protected void add_comment_btn_Click(object sender, EventArgs e)
    {

        Comment comment = new Comment();
        comment.user = (Session["User"] as Table).user;
        comment.text = comment_input.Text;
        comment.time = DateTime.Now;
        db.InsertComment(comment);

        comment_input.Text = string.Empty;
        comment_repeater.DataSource = db.GetAllComment();
        comment_repeater.DataBind();

        update_panel.Update();
    }

    protected void change_passwd_Click(object sender, EventArgs e)
    {
        Response.Redirect("./ChangePassword.aspx");
    }

    protected void system_manager_Click(object sender, EventArgs e)
    {
        Response.Redirect("./SystemManage.aspx");
    }

    protected void exit_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("./Login.aspx");
    }

    void HandleLogin()
    {
        if (Session["Admin"] != null)
        {
            welcom.Text = "Welcome back,管理员" + (Session["User"] as Table).name;
            change_passwd.Visible = false;
        }

        else if (user != null)
        {
            welcom.Text = "Welcome back," + user.name;
            system_manager.Visible = false;
        }
        else
        {
            //Response.Redirect("./Login.aspx");
        }
    }
}
