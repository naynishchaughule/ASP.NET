using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Basics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //control model
        lblDisplay.Text = "Hello, " + "<span style=\"color:red \">" +Page.Request.Form["txtName"] + "</span>";
    }

    protected void chbxEvent_Click(object sender, EventArgs e)
    {
        lblDisplay.Text = "checkbox fired";
    }
}