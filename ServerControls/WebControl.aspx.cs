using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class WebControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.BackColor = Color.LightYellow;
        TextBox1.BorderColor = Color.LimeGreen;
        TextBox1.BorderStyle = BorderStyle.Groove;
        //TextBox1.Enabled = false;
        TextBox1.Font.Italic = true;
        TextBox1.ForeColor = Color.Gray;
        TextBox2.TabIndex = 0;
        TextBox1.ToolTip = "enter name";
        TextBox1.Width = new Unit(118);
    }
}