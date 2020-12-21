﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DB db = new DB();
    protected void Page_Load(object sender, EventArgs e)
    {
        comment_repeater.DataSource = db.GetAllComment();
        comment_repeater.DataBind();
        update_panel.Update();
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
}
